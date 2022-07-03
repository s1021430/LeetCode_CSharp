namespace LeetCode
{
    public class RemoveElement_27
    {
        public static int RemoveElement(int[] nums, int val)
        {
            var length = 0;
            for (var i = 0; i < nums.Length; i++) 
                if (nums[i] != val)
                    nums[length++] = nums[i];
            return length;
        }
    }
}