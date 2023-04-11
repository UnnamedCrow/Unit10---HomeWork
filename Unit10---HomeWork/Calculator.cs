using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit10___HomeWork
{
    class Calculator : ICalculator
    {
        Logger logger { get; }
        // storage of numbers
        int?[] nums;
        // interface function
        void ICalculator.Add()
        {
            try
            {
                ((ILogger)logger).Event("Addition two numbers");
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
            ((ILogger)logger).Event("Start reading numbers");
            // Read first number from console
            while (nums[0] == null)
            {
                try
                {
                    ((ILogger)logger).Event("Enter first number: ");
                    nums[0] = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    logger.Error("Ooops! Wrong number format");
                    nums[0] = null;
                }
                catch(OverflowException)
                {
                    logger.Error("Ooops! Nuber out of range");
                    nums[0] = null;
                }
                catch(Exception ex)
                {
                    logger.Error("Ooops! " + ex.Message);
                    nums[0] = null;
                }
            }
            int a;
            // Read second number from console
            while (nums[1] == null)
            {
                try
                {
                    ((ILogger)logger).Event("Enter second num :");
                    if (int.TryParse(Console.ReadLine(), out a))
                        nums[1] = a;
                    else
                        throw new Exception("Ooops! Wrong value entered");
                }
                catch(Exception ex)
                {
                    logger.Error(ex.Message);
                    nums[1] = null;
                }
            }
            ((ILogger)logger).Event("Reading numbers complited");
        }
        // Calculators constructor
        public Calculator(Logger logger)
        {
            this.logger = logger;
            this.nums = new int?[2] {null , null}; 
        }
    }
}
