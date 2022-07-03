namespace LeetCode
{
    public class _101SymmetricTree
    {
        public class TreeNode 
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        
        public static bool IsSymmetric(TreeNode root) {
            if(root == null) return true;
            return NodeCompare(root.left, root.right) && NodeCompare(root.right, root.left);
        }
    
        private static bool NodeCompare(TreeNode left, TreeNode right)
        {
            if(left == null || right == null)
                return left==right;
            if(left.val != right.val)
                return false;
            return NodeCompare(left.left, right.right) && NodeCompare(left.right, right.left);
        }
    }
}