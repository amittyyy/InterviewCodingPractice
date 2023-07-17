using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiMapConcept
{
    internal class FibonacciSeries
    {

        public static int fibonacciSer(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
               return fibonacciSer(n - 1) + fibonacciSer(n - 2);
        }

        public static List<int> generateFibonacci(int number)
        {
            List<int> lst = new List<int>();

            if(number == 0)
            {
                lst.Add(0);
                return lst;
            }
            if(number == 1)
            {
               lst = new List<int> { 0, 1 };
                return lst;
            }
                

            int a = 0, b = 1;
            int c = 0;
            

            while(number > 1)
            {
                c = a + b;

                a = b;
                b = c;

                lst.Add(c);

                if(c==number)
                    break;

                if (number < c)
                    break;
               
            }

            return lst;
        }
    }
}
