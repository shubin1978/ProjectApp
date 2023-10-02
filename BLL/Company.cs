using System.Runtime.InteropServices.JavaScript;
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
    public List<Object> FindObjectByPlace(string pos) => _context.Objects.Where(o => o.Position.Contains(pos)).ToList();

    #endregion
}