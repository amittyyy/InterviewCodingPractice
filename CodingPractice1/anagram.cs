using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiMapConcept
{
    public class anagram
    {
        public static bool  isAnagram(string str1, string str2)
        {
            if (string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2))
                return false;

            if (str1.Length != str2.Length)
                return false;

            char[] array1 = str1.ToCharArray();
            char[] array2 = str2.ToCharArray();

            Array.Sort(array1);
            Array.Sort(array2);

            string arrangedStr1 = new string(array1);
            string arrangedStr2 = new string(array2);

            return arrangedStr1 == arrangedStr2;

        }

    }
}
