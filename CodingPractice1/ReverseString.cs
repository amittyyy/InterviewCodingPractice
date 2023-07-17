using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiMapConcept
{
    public class ReverseString
    {
        public static string reverseString(string str)
        {
            if (str == null) return null;


            char[] chars = str.ToCharArray();

            Array.Reverse(chars);

            return new string(chars);
        }

        //using linq

        public static string reverseStringLinq(string str)
        {
            return new string(str.Reverse().ToArray());
        }
    }
}
