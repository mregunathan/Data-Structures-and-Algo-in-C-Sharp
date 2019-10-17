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
    public int KthSmallest(TreeNode root, int k) {
        List<int> res = new List<int>();
        inorder(root, res);
        return res[k-1];
    }
    
    public void inorder(TreeNode node, List<int> res)
    {
        // Recursive
        /*
        if(node != null)
        {
            inorder(node.left, res);
            res.Add(node.val);
            inorder(node.right, res);
        }
        */
        Stack<TreeNode> st = new Stack<TreeNode>();
        TreeNode curr = node;
        while(curr!=null || st.Count !=0)
        {
            while(curr!=null)
            {
                st.Push(curr);
                curr = curr.left;
            }
            curr = st.Pop();
            res.Add(curr.val);
            curr = curr.right;
        }
    }
}