using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class TwoSumLessThanK
    {
        List<KeyValuePair<int,int>> twoSumLessThanK(int[] A, int K) 
        {
            var result = new List<KeyValuePair<int,int>>();
            var left = 0;
            var right = A.Length-1;
            Array.Sort(A);
            while (left < right) 
            {
                if (A[left] + A[right] < K)
                {
                    var repeatPair = result.Where(p => p.Key == A[left]);
                    var repeat = repeatPair.Any(p => p.Value == A[right]);
                    if(!repeat)
                        result.Add(new KeyValuePair<int, int>(A[left],A[right]));
                    left++;
                } 
                else
                    right--;
            }
            return result;
        }
    }
}