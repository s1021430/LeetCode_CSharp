using System.Linq;

namespace LeetCode
{
    public class ImplementStrStr_28
    {
        public static int StrStr(string haystack, string needle) 
        {
            if(haystack.Length < needle.Length) return -1;
            if(haystack == needle) return 0;
            for(var i = 0;i < haystack.Length - needle.Length + 1;i++)
            {
                if (haystack[i] != needle[0]) continue;
                if (needle.TakeWhile((n, j) => haystack[i+j] == n)
                    .Where((t, j) => j == needle.Length-1).Any())
                {
                    return i;
                }
            }
            return -1;
        }
    }
}