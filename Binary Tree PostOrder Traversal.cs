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
    public IList<int> PostorderTraversal(TreeNode root) {
        // Iterative - using 2 stacks - not sure how
        
        //Recursive
        List<int> res = new List<int>();
        Helper(root, res);
        return res;
    }
    
    public void Helper(TreeNode root, List<int> res)
    {
        if(root!=null)
        {
            Helper(root.left, res);
            Helper(root.right, res);
            res.Add(root.val);
        }
    }
}