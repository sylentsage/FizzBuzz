using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzComponent
{
    public class FizzBuzz
    {
        // Variables 
        private int _fizz = 0;
        private int _buzz = 0;

        // Default Constructor 
        public FizzBuzz()
        {
            _fizz = 3;
            _buzz = 5;
        }

        // Constructor 
        public FizzBuzz(int fizz, int buzz){          
            _fizz = fizz;
            _buzz = buzz;
        }
        
        // Print FizzBuzz
        public string PrintFizzBuzz(int num)
        {
            if (num % _fizz == 0 && num % _buzz == 0)
                return "FizzBuzz";
            else if (num % _fizz == 0)
                return "Fizz";
            else if (num % _buzz == 0)
                return "Buzz";
            else
                return num.ToString();
        }// end PrintFizzBuzz 
    }// end FizzBuzz class
}// end namespace
