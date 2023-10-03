using Object = ProjectApp.Model.Object;

namespace ProjectApp.CLI;

public static class CompanyView
{
    public static void ShowObject(Object obj)
    {
        CLI.PrintInfo($"{obj.At} {obj.Title} : {obj.Position} -> {obj.Status}");
    }

    public static void ShowObjects(List<Object> objects)
    {
        foreach (var o in objects)
        {
            ShowObject(o);
        }
    }
}