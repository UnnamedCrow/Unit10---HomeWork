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
            Logger logger= new Logger();
            Calculator calculator = new Calculator(logger);

            Console.WriteLine("Hello! Now we will add two numbers");
            calculator.Read();
            ((ICalculator)calculator).Add();
            Console.ReadLine();
        }
    }
}
