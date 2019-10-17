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
    public IList<int> PreorderTraversal(TreeNode root) {
        
        // Recursive approach
        /*
        List<int> res = new List<int>();
        Helper(root, res);
        return res;
        */
        // Iterative appraoch using stack
        TreeNode node = root;
        List<int> res = new List<int>();
        Stack<TreeNode> st = new Stack<TreeNode>();
        st.Push(root);
        while(node!= null || st.Count != 0)
        {
            node = st.Pop();
            res.Add(node.val);
            while(node.right !=null)
            {
                st.Push(node.right);
            }
            while(node.left !=null)
            {
                st.Push(node.left);
            }
            
        }
        return res;
    }
    
    public void Helper(TreeNode node, List<int> res)
    {
        if(node != null)
        {
            res.Add(node.val);
            Helper(node.left, res);
            Helper(node.right, res);
        }
    }
}