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
    // Only HashSet
    /*
    public bool FindTarget(TreeNode root, int k) {
        HashSet<int> hset = new HashSet<int>();
        return helper(root, k, hset);   
    }    
    
    public bool helper(TreeNode root, int k, HashSet<int> hset)
    {
         if(root == null)
            return false;
        if(hset.Contains(k - root.val))
            return true;
        hset.Add(root.val);
        return helper(root.left, k, hset) || helper(root.right, k, hset);
    }
    */
    //DFS & 2 pointers
    /*
    public bool FindTarget(TreeNode root, int k) {
        List<int> values = new List<int>();
        InOrderTraversal(root, values);
        
        int left = 0, right = values.Count - 1;
        
        while(left < right)
        {
            if(values[left] + values[right] == k)
                return true;
            else if (values[left] + values[right] < k)
                left++;
            else
                right --;
        }
        return false;
    }
    
    public void InOrderTraversal(TreeNode root, List<int> values)
    {
        if(root == null)
            return;
        InOrderTraversal(root.left, values);
        values.Add(root.val);
        InOrderTraversal(root.right, values);
    }
    */
    // BFS and HashSet
    public bool FindTarget(TreeNode root, int k) {
        HashSet<int> hset = new HashSet<int>();
    }
    
    public void InOrderTraversal(TreeNode root, HashSet<int> hset)
    {
        if(root == null)
            return;
        InOrderTraversal(root.left, hset);
        hset.Add(root.val);
        InOrderTraversal(root.right, hset);
    }
}