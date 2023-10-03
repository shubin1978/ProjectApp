
using System.Text.Json;
using ProjectApp.BLL;
using ProjectApp.CLI;
using ProjectApp.DAL;
using ProjectApp.Model;
using Object = ProjectApp.Model.Object;

var company = new Company(new JsonContext("objects.json"));
/*context.Objects = new List<Object>
{
 new()
 {
  At = 326001010,
  Title = "PC-400_#605",
  Position = "Quarry",
  Status = Status.Avtive,
  Equipment = new List<Unit>
  {
   new Unit(2222, "LLS4"),

   new Unit(2223, "LLS4")
  }
 }
};*/

var objects = company.GetAllObjects();
CompanyView.ShowObjects(objects);
var position = CLI.InputString("Введите локацию для поиска");
var listObjectsLocation = company.FindObjectByPlace(position);
CompanyView.ShowObjects(listObjectsLocation);