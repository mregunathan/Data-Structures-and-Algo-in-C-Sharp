public class Solution {
    // Brute Force - for loop - O(n)
    public int RemoveElement(int[] nums, int val) {

        int count = 0;
        for(int i =0; i<nums.Length; i++)
        {
            if(nums[i] ==  val)
            {
                count ++;
            }
            else
            {
                nums[i-count] = nums[i];
            }
        }        
        return nums.Length-count;
    }
    
    /* 2 pointer solution
    public int RemoveElement(int[] nums, int val) {
        int len = nums.Length;
        int count = 0;
        */
}