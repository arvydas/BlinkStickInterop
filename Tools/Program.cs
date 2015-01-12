using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0 && args[0] == "/buildString")
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                object[] attributes = assembly.GetCustomAttributes(true);
                object configRaw = attributes.FirstOrDefault(a => a.GetType() == typeof(AssemblyConfigurationAttribute));
                if (configRaw != null) {
                    String _ApplicationVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
                    _ApplicationVersion = _ApplicationVersion.Substring(0, _ApplicationVersion.LastIndexOf('.'));
                    _ApplicationVersion = _ApplicationVersion.Substring(0, _ApplicationVersion.LastIndexOf('.'));

                    AssemblyConfigurationAttribute config = (AssemblyConfigurationAttribute)configRaw;
                    string configuration;
#if _WIN64
                    configuration = "_x64";
#else
                    configuration = "_x86";
#endif
                    Console.WriteLine(_ApplicationVersion + "_" + config.Configuration + configuration);
                    return;
                }

                Console.WriteLine("");
                return;
            }
        }
    }
}
