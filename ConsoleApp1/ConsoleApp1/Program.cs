using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Class1.getVariable());

            Class1.setVariable(3);

            Console.WriteLine(Class1.getVariable());


        }
    }
}
