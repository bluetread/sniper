using System;
using System.IO;
using System.Reflection;
using static Sniper.Application.ApplicationKeys;

namespace Sniper
{
    public static class FileSystemHelpers
    {
        public static string AssemblyDirectory => GetPartialPath(GetCodeBase(typeof(FileSystemHelpers)), CurrentAssemblyName);
        public static string CurrentAssemblyName => GetAssemblyName(Assembly.GetExecutingAssembly());

        public static string GetAssemblyName(Assembly assembly)
        {
            Ensure.ArgumentNotNull(nameof(assembly), assembly);
            return assembly.GetName().Name;
        }

        public static string RootSolutionPath => AppDomain.CurrentDomain.BaseDirectory
            .Substring(0, AppDomain.CurrentDomain.BaseDirectory.LastIndexOf(ApplicationProjectName, 
                StringComparison.CurrentCultureIgnoreCase) + ApplicationProjectName.Length);

        public static string RootSourcePath => AppDomain.CurrentDomain.BaseDirectory
            .Substring(0, AppDomain.CurrentDomain.BaseDirectory.IndexOf(CurrentAssemblyName,
                StringComparison.CurrentCultureIgnoreCase));

        public static void DeleteFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
        }

        private static string GetCodeBase(Type type)
        {
            return Assembly.GetAssembly(type)?.CodeBase;
        }

        private static string GetPartialPath(string codebase, string assemblyName)
        {
            var rootPath = codebase.Substring(0,
                codebase.IndexOf(assemblyName, StringComparison.CurrentCultureIgnoreCase) + assemblyName.Length + 1);

            var uri = new UriBuilder(rootPath);
            var path = Uri.UnescapeDataString(uri.Path);
            return Path.GetDirectoryName(path);
        }
    }
}
