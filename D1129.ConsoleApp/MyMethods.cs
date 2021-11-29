using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1129.ConsoleApp
{
    internal class MyMethods
    {
        public static string PrintName(string name)
        {
            if (name != null)
            {
                return $"Nome: {name}";
            }
            return "Nome: null";          
            
        }

        public static void PrintName2(string name)
        {
            Console.WriteLine(name);
        }
    }
}
