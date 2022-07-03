using System.Collections.Generic;

namespace LeetCode
{
    public class _94BinaryTreeInorderTraversal
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
        
        private static readonly List<int> result = new List<int>();

        public static IList<int> InorderTraversal(TreeNode root)
        {
            NodeTraverse(root);
            return result;
        }

        private static void NodeTraverse(TreeNode node)
        {
            if (node == null)
                return;
            if (node.left != null) //Go left node first until null.
                NodeTraverse(node.left);
            result.Add(node.val); //Traverse parent node.
            if (node.right != null) //Go left node right until null.
                NodeTraverse(node.right);
        }
    }
}