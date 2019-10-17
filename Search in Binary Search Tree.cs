/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode SearchBST(TreeNode root, int val) {
        TreeNode ret = root;
        if(root == null) return null;
        if(val == root.val)
        {
            ret = root;
        }
        else if(val < root.val)
        {
            ret = SearchBST(root.left, val);
        }
        else if(val > root.val)
        {
            ret = SearchBST(root.right, val);
        }
        return ret;
    }
}