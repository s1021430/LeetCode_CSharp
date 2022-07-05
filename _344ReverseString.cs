using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _344ReverseString
    {
        public static void ReverseString(char[] s)
        {
            var j = s.Length - 1;
            for (var i = 0; i < s.Length; i++)
            {
                if (i >= j)
                    return;
                Swap(s, i, j);
                j--;
            }
        }

        private static void Swap(char[] s, int first, int second)
        {
            (s[first], s[second]) = (s[second], s[first]);
        }
    }
}
