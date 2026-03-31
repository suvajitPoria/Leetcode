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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        return Travers(p,q);
    }
    private bool Travers(TreeNode p, TreeNode q)
    {
        if(p == null && q == null)
        {
            return true;
        }
        if(p == null || q == null)
        {
            return false;
        }
        if(p.val != q.val)
        {
            return false;
        }
        return Travers(p.left,q.left) && Travers(p.right, q.right);
    }
}
