using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit10___HomeWork
{
    class Calculator : ICalculator
    {
        // storage of numbers
        int?[] nums;
        // interface function
        void ICalculator.Add()
        {
            try
            {
                Console.WriteLine($"{nums[0]} + {nums[1]} = {nums[0] + nums[1]}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        // Read two numbers from console 
        public void Read()
        {
            // Read first number from console
            while (nums[0] == null)
            {
                try
                {
                    Console.Write("Enter first num :");
                    nums[0] = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong number format");
                    nums[0] = null;
                }
                catch(OverflowException)
                {
                    Console.WriteLine("Nuber out of range");
                    nums[0] = null;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    nums[0] = null;
                }
            }
            int a;
            // Read second number from console
            while (nums[1] == null)
            {
                try
                {
                    Console.Write("Enter second num :");
                    if (int.TryParse(Console.ReadLine(), out a))
                        nums[1] = a;
                    else
                        throw new Exception("Wrong value entered");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    nums[1] = null;
                }
            }
        }
        // Calculators constructor
        public Calculator()
        {
            this.nums = new int?[2] {null , null}; 
        }
    }
}
