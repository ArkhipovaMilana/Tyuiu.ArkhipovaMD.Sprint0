using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiy.ArkhipovaMD.Sprint0.Task6.V0.Lib;

namespace Tyuiy.ArkhipovaMD.Sprint0.Task6.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arraynums = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Sum: " + DataService.AdditionArray(arraynums));
            Console.WriteLine("Sub: " + DataService.SubtractionArray(arraynums));
            Console.WriteLine("Mul: " + DataService.MultiplicationArray(arraynums));
            Console.ReadKey();
        }
    }
}
