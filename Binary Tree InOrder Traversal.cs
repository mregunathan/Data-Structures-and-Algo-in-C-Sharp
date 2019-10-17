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
    public IList<int> InorderTraversal(TreeNode root) {
        // Recursive Method
        /*
        List<int> inorderNodes = new List<int>();
        Helper(root, inorderNodes);
        return inorderNodes;
        */
        
        //Iterative Method using stack
        List<int> inorderNodes = new List<int>();
        Stack<TreeNode> st = new Stack<TreeNode>();
        TreeNode curr = root;
        while(curr!=null || st.Count!= 0)
        {
            while(curr != null)
            {
                st.Push(curr);
                curr = curr.left;
            }
            curr = st.Pop();
            inorderNodes.Add(curr.val);
            curr = curr.right;
        }
        return inorderNodes;
    }
    
    public void Helper(TreeNode node, List<int> result)
    {
        if(node != null)
        {
            Helper(node.left, result);
            result.Add(node.val);
            Helper(node.right, result);
        }
    }
}