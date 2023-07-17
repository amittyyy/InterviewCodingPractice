using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MultiMapConcept
{
    public class OccuranceCharOfString
    {
        //using for loop

        public static int CountOcurance(char c, string str)
        {
            //base case 
            if (string.IsNullOrEmpty(str)) return 0;


            //Count both capital and small letter
            var inputString = str.ToLower();

            //extensive case
            int count = 0;

            foreach(char item in inputString)
            {
                if (c == item) count++;
            }

            return count;
        }


        // using linq
        public static int countOccuranceLinq(char c, string str)
        {
            //base case
            if(string.IsNullOrEmpty(str)) return 0;

            //extensive case
            var inputString = str.ToLower();

            var count = inputString.Count(x => x.Equals(c));

            return count;
        }

        //Recursion 

        public static int countOccuranceRecursive(char c, string str)
        {
            int count = 0;

            // base case
            if(string.IsNullOrEmpty(str)) return 0;

            var inputString = str.ToLower();

            //extensive cases
            if (inputString[0] == c)
                count++;

            count += countOccuranceRecursive(c, inputString.Substring(1));

            return count;


        }
    }
}
