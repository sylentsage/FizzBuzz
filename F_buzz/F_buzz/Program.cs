using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f_buzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int start = 1;
            int end = 100;

            // Initnalize FizzBuzz Object 
            FizzBuzzComponent.FizzBuzz fbObject = new FizzBuzzComponent.FizzBuzz(3,5);

            for (int i = start; i <= end; i++)
            {
                // Call PrintFizzBuzz 
                Console.WriteLine(fbObject.PrintFizzBuzz(i));
            }

            // Pause After Printing List
            Console.ReadLine();
        }
    }
}
