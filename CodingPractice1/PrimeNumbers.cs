using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice
{
    internal class PrimeNumbers
    {

        public static bool isPrimeLinq(int number)
        {
            if(number < 1) return false;
            if(number == 2) return true;

            if(number > 2)
            {
                return Enumerable.Range(2,number/2).All(x => number % x != 0);
            }

            return false;
        }

        public static bool isPrimeFor(int number)
        {
            if (number < 1) return false;
            if (number == 2) return true;

            double squarRoot = Math.Sqrt(number);

            for(int i = 2; i<= Math.Sqrt(number); i++)
            {
                if(number % i == 0)
                    return false;                    
            }

            return true;
        }
    }
}
