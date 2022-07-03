using System.Collections.Generic;

namespace LeetCode
{
    public class _70ClimbingStairs
    {
        private static readonly Dictionary<int,int> climbingTable = new();
        public static int ClimbStairs(int n) {
            if(n <= 1) return 1;
        
            if(climbingTable.ContainsKey(n))
                return climbingTable[n];
        
            climbingTable[n] = ClimbStairs(n-1) + ClimbStairs(n-2);
            return climbingTable[n];
        }
    }
}