public class Solution {

    public bool IsSymmetric(TreeNode root) {

        if(root == null)
        {
            return true;
        }

        return IsMirror(root.left, root.right);
    }

    private bool IsMirror(TreeNode left, TreeNode right)
    {
        // both null
        if(left == null && right == null)
        {
            return true;
        }

        // one null
        if(left == null || right == null)
        {
            return false;
        }

        // values not same
        if(left.val != right.val)
        {
            return false;
        }

        // recursive mirror check
        return IsMirror(left.left, right.right)
            && IsMirror(left.right, right.left);
    }
}
