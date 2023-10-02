using System.Runtime.InteropServices.JavaScript;
using System.Text.Encodings.Web;
using System.Text.Json;
using Object = ProjectApp.Model.Object;

namespace ProjectApp.DAL;

public class JsonContext : FileContext, IContext
{
    public List<Object> Objects { get; set; }
    private readonly JsonSerializerOptions _options;
    
    public JsonContext(string pathToObjects) : base(pathToObjects)
    {
        Objects = new List<Object>();
        
        _options = new JsonSerializerOptions
        {
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };
    }
    
    public void ImportObjects()
    {
        var objectJson = File.ReadAllText(PathToObjects);
        Objects = JsonSerializer.Deserialize<List<Object>>(objectJson);
    }

    public void ExportObjects()
    {
        var objectsJson = JsonSerializer.Serialize(Objects, _options);
        File.WriteAllText(PathToObjects,objectsJson);
    }
}