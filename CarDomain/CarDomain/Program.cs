using System;
using System.Reflection;
using System.Security.Permissions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using carlib;

namespace CarDomain
{
    internal class Program
    {
        [PermissionSetAttribute(SecurityAction.Demand, Name = "FullTrust")]
        static void Main(string[] args)
        {
            Assembly a = null;

            try
            {
                a = Assembly.Load(args[0]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            AppDomain ad = AppDomain.CurrentDomain;
            Assembly[] loaded = ad.GetAssemblies();
            foreach (Assembly assembly in loaded)
            {
                Console.WriteLine(assembly.FullName);
            }

            Type[] mytypes = a.GetTypes();

            BindingFlags flags = (
                BindingFlags.NonPublic |
                BindingFlags.Public |
                BindingFlags.Instance |
                BindingFlags.Static |
                BindingFlags.DeclaredOnly);

            foreach (Type type in mytypes)
            {
                MethodInfo[] mi = type.GetMethods(flags);
                foreach (MethodInfo m in mi)
                {
                    Console.WriteLine(m);
                }
            }

            // Позднеее связывание
            Console.WriteLine();
            Type mv = a.GetType("carlib.MiniVan");

            Object obj = Activator.CreateInstance(mv);
            MethodInfo mvmi = mv.GetMethod("TurboBoost");
            mvmi.Invoke(obj, null);

            // Динамическая сборка
            Console.WriteLine();
            AppDomain dm = AppDomain.CreateDomain("CARS");
            dm.ExecuteAssembly("Работа_CS_401.exe");
            AppDomain.Unload(dm);
        }
    }
}
