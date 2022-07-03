using System.Collections.Generic;

namespace LeetCode
{
    public class ValidParentheses
    {
        public static bool IsValid(string s)
        {
            if (s.Length % 2 == 1)
                return false;
            var parenthesesDic = new Dictionary<char, char>
            {
                {')','('},
                {']','['},
                {'}','{'}
            };
            var inputStack = new Stack<char>();
            foreach (var c in s)
            {
                if (parenthesesDic.ContainsValue(c))
                    inputStack.Push(c);
                else
                {
                    if (inputStack.Count == 0)
                        return false;
                    if (inputStack.Peek() == parenthesesDic[c])
                        inputStack.Pop();
                }
            }
            return inputStack.Count == 0;
        }
    }
}