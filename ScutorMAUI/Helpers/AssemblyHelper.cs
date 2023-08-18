using System.Diagnostics;
using System.Reflection;
using System.Runtime.Loader;

namespace ScutorMAUI.Helpers
{
    public static class AssemblyHelper
    {
        public static List<Assembly> GetAllAssemblies(SearchOption searchOption = SearchOption.TopDirectoryOnly)
        {
            var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var assemblyFiles = Directory.GetFiles(baseDirectory, "*.dll", searchOption);

            foreach (string assemblyPath in assemblyFiles)
            {
                try
                {
                    var assembly = AssemblyLoadContext
                    .Default
                    .LoadFromAssemblyPath(assemblyPath);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                }
            }
            return AssemblyLoadContext.Default.Assemblies.ToList();
        }
    }
}
