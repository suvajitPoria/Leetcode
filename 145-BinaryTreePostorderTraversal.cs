/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<int> PostorderTraversal(TreeNode root) {
     PostOrder(root);
     return list;   
    }
    List<int> list = new List<int>();
    private void PostOrder(TreeNode root)
    {
        if(root != null)
        {
            PostOrder(root.left);
            PostOrder(root.right);
            list.Add(root.val);
        }
    }
}
