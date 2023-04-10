using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit10___HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("Hello! Now we will add two numbers");
            calculator.Read();
            ((ICalculator)calculator).Add();
            Console.ReadLine();
        }
    }
}
