using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace test02
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Inter itemGet = new common();
                var plugindir = System.IO.Directory.GetParent(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName).CreateSubdirectory("startup");
                foreach (var filesInPlugin in plugindir.GetFiles())
                {
                    if (filesInPlugin.Extension.ToLower() == ".dll")
                    {
                        if (AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(x => x.ManifestModule.ScopeName == filesInPlugin.Name) != null)
                            continue;
                        else
                        {
                            byte[] rawAssembly = File.ReadAllBytes(filesInPlugin.FullName);
                            itemGet = Load(rawAssembly);
                            Console.WriteLine(itemGet.FirstName);
                        }
                    }
                };
                Console.ReadLine();
            } while (true);
        }

        static Inter Load(byte[] rawAssembly)
        {
            Assembly dllFromPlugin = Assembly.Load(rawAssembly);
            foreach (var dllModule in dllFromPlugin.GetLoadedModules())
            {
                foreach (var typeDefinedInModule in dllModule.GetTypes())
                {
                    if (typeDefinedInModule.GetInterfaces().Contains(typeof(Inter)))
                    {
                        if (typeDefinedInModule.IsClass)
                        {
                            return System.Activator.CreateInstance(typeDefinedInModule) as Inter;
                        }
                    }
                }
            }
            return null;

        }
    }
}
