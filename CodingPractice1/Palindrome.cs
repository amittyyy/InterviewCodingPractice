using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiMapConcept
{
    public class Palindrome
    {
        public static bool palindromes(string str)
        {
            //Base case 1
            if (str.Length == 0 || string.IsNullOrEmpty(str)) return false;

            //Base case 2

            string inputString = string.Concat(str.Where(c => !Char.IsWhiteSpace(c)));

            // string input = inputString.Replace(" ", "");


            for(int i=0; i<str.Length/2; i++)
            {
                char test1 = str[i];
                char test2 = str[str.Length-(i+1)];

                if (str[i] != str[str.Length - (i + 1)])
                    return false;                    
            }

            return true;
        }

        public static bool isPalindrome(string str)
        {
            //basecase
            if(string.IsNullOrEmpty(str)) return false;

            //Remove while space
            var inputString = string.Concat(str.Where(c => !Char.IsWhiteSpace(c)));


            char[] arrrChar = inputString.ToCharArray();

            Array.Reverse(arrrChar);

            string reversedString = new string(arrrChar);

            if (inputString != reversedString)
                return false;

            return true;                


        }

        public static bool isPalindromeInt(int number)
        {
            //base case
            if(number < 10) return false;

            int tempNumber = number;
            int remainder = 0;
            int sum = 0;

            while(number > 0)
            {
                remainder = number % 10;
                sum = sum * 10 + remainder;
                number = number / 10;
            }

            return tempNumber == sum;


        }
    }
}
