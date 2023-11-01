﻿using System.Runtime.InteropServices.JavaScript;
using ProjectApp.DAL;
using Object = ProjectApp.Model.Object;

namespace ProjectApp.BLL;

public class Company
{
    private readonly IContext _context;

    public Company(IContext context)
    {
        _context = context;
        _context.ImportObjects();
    }

    #region Objects

    public List<Object> GetAllObjects() => _context.Objects;
    public List<Object> FindObjectByPlace(string pos) => _context.Objects.Where
        (o => o.Position.Contains(pos)).ToList();
    
    //public List<Object> FindObjectsByTitle(string title) => _context.Objects.Where
    //(o => o.Title.Contains(title)).ToList();

    public List<Object> FindObjectsByTitle(string title) => (from obj in _context.Objects
        where obj.Title.Contains(title)
        select obj).ToList();

    /*public Object FindObjectByTitle(string title)
    {
        foreach (var ob in _context.Objects)
        {
            if (ob.Title.Contains(title))
            {
                return ob;
            }
        }
        return null;
    }*/

    #endregion
}