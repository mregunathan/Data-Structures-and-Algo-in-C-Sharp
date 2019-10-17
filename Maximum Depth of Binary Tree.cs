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
    public int MaxDepth(TreeNode root) {
        // Find max depth of left subtree & right subtree recursively.
        // Max depth is max of these 2 + 1 for current node
        if(root == null)
            return 0;
        int leftdepth = MaxDepth(root.left);
        int rightdepth = MaxDepth(root.right);
        
        return Math.Max(leftdepth, rightdepth) + 1;
    }
}