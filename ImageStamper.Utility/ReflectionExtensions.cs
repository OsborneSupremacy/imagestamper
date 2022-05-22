using System.Reflection;

namespace ImageStamper.Utility;

public static class ReflectionExtensions
{
    public static List<Type> GetTypesInAssembly(this Type input) =>
        Assembly.GetAssembly(input)!
            .GetTypes()
            .Where(x => !x.IsAbstract)
            .Where(x => x.IsPublic)
            .ToList();
}
