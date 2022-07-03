using System.Collections.Generic;

namespace LeetCode
{
    public class _1TwoSum
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var dictionary = new Dictionary<int, int>();
            var result = new int[2];
            for (var i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];
                if (dictionary.ContainsKey(complement))
                {
                    result[0] = dictionary[complement];
                    result[1] = i;
                    break;
                }

                if (!dictionary.ContainsKey(nums[i]))
                    dictionary.Add(nums[i], i);
            }

            return result;
        }
    }
}