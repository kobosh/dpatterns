using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactorypatternLib;
using System.Reflection;
namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Assembly assemblyx = Assembly.Load("FactorypatternLib");
            foreach (var assemblyName in Assembly.GetExecutingAssembly()
                .GetReferencedAssemblies())
            {
                Assembly assembly = Assembly.Load(assemblyName);
                foreach (var type in assembly.GetTypes())
                {
                    Console.WriteLine(type.Name);
                }
            }*/

            //Assembly.GetAssembly()
            MachineFactory mf = new MachineFactory();
         var r=   mf.CreateInstance("rob");
            r.TurnOn();

            //Type[] types = Assembly.GetAssembly( typeof(FactorypatternLib.)).GetTypes();
            Console.WriteLine();
        }
    }
}
