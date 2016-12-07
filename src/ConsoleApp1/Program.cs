using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string curMach = Environment.MachineName;
            Console.Write(curMach);
            Console.ReadKey();
        }
    }
}
