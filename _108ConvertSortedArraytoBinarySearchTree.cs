namespace LeetCode
{
    public class _108ConvertSortedArraytoBinarySearchTree
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        public TreeNode SortedArrayToBST(int[] nums)
        {
            return nums == null ? null : ToBST(nums, 0, nums.Length - 1);
        }

        private static TreeNode ToBST(int[] nums, int left,int right)
        {
            if (left > right)
                return null;

            var mid = left + (right - left) / 2;
            var root = new TreeNode(nums[mid])
            {
                left = ToBST(nums, left, mid - 1),
                right = ToBST(nums, mid + 1, right)
            };

            return root;
        }
    }
}