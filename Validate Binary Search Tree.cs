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
    public bool IsValidBST(TreeNode root) {
        return Helper(root, null, null);
    }
    
    public bool Helper(TreeNode node, int? lower, int? upper)
    {
        if(node == null) return true;
        if(lower.HasValue && node.val <= lower.Value)
            return false;
        if(upper.HasValue && node.val >= upper.Value)
            return false;
        
        if(!Helper(node.left, (lower.HasValue? lower.Value : (int?)null), node.val))
            return false;
        if(!Helper(node.right, node.val, upper.HasValue? (int?)upper.Value : null))
            return false;  
        
        return true;
    }
}