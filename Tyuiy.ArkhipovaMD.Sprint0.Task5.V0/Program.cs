using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiy.ArkhipovaMD.Sprint0.Task5.V0.Lib;

namespace Tyuiy.ArkhipovaMD.Sprint0.Task5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(5, 5));
            Console.WriteLine(DataService.Subtraction(5, 5));
            Console.WriteLine(DataService.Multiplication(5, 5));
            Console.WriteLine(DataService.Division(5,0));
            Console.ReadKey();
        }
    }
}

