public class Solution {
    
    
    public int RemoveDuplicates(int[] nums) {
        // Brute Force
        /*
        int l = 0;
        
        for(int i =0; i< nums.Length; i++)
        {
            for(int j =i+1; j< nums.Length; j++)
            {
                if(nums[i] !=  nums[j])
                {
                    nums[i] = nums[j];
                    l++;
                }
            }
        }        
        
        return nums.Length - (l + 1);
        */
        // Remove dupliactes like an unsorted array
        /*
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int count = 0;
        for(int i=0;i<nums.Length; i++)
        {
            if(dict.ContainsKey(nums[i]))
            {
                count ++;
            }
            else
            {
                dict.Add(nums[i], 1);
                nums[i-count] =  nums[i];
            }
        }
        
        return nums.Length - count;
        */
        // Two pointers since its a sorted array
        if (nums.Length ==0)
            return 0;
        int j = 0;
        for(int i=1;i<nums.Length;i++)
        {
            if(nums[i] != nums[j])
            {
                j++;
                nums[j] =  nums[i];
            }            
        }
        return j+1;
    }
}	