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
    public IList<int> InorderTraversal(TreeNode root) {
        Inorder(root);
        return list;
    }
    List<int> list = new List<int>();
    private void Inorder(TreeNode root)  
    {
        if(root != null)
        {
            Inorder(root.left);
            list.Add(root.val);
            Inorder(root.right);
        }
    }
}
