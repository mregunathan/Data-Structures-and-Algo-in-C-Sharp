public class Solution {
    /* Brute Force Slution
    public int[] TwoSum(int[] nums, int target) {
        int n = nums.Length;
        int[] ar = new int[2];

        for(int i=0;i<n;i++)
        {
            for(int j=i+1;j<n;j++)
            {
                if(nums[i]+nums[j]==target)
                {
                    ar[0] = i;
                    ar[1] = j;
                }
            }
        }
        return ar;
    }
    
    Two Pass
    public int[] TwoSum(int[] nums, int target) {
        int[] result = new int[2];
        int n = nums.Length;
        
        Dictionary<int,int> dict = new Dictionary<int,int>();
        
        for(int i=0; i<n; i++)
        {            
            int Value = 0;
            if(!dict.TryGetValue(nums[i], out Value))
            {
                dict.Add(nums[i], i);
            }
        }
        for(int i=0; i<n; i++)
        {
            Console.WriteLine(nums[i] + "   " + dict[nums[i]]);
        }
        for(int i=0; i<n; i++)
        {
            int sum = target - nums[i];
            int Value;
            if(dict.TryGetValue(sum, out Value))
            {
                Console.WriteLine("Inside if loop with index" + Value);
                if(Value != i)
                {
                    result[0] = i;
                    result[1] = Value;
                    break;
                }
            }
        }
        return result;
    }
    */
    // One Pass Dictionary
    public int[] TwoSum(int[] nums, int target) {
        int[] result = new int[2];
        int n = nums.Length;
        
        Dictionary<int,int> dict = new Dictionary<int,int>();
        
        for(int i=0;i<n;i++)
        {
            int sum = target - nums[i];
            if(dict.ContainsKey(sum))
            {
                result[0] = dict[sum];
                result[1] = i;
                break;
            }
            else
            {
                if(!dict.ContainsKey(nums[i]))
                    dict.Add(nums[i], i);
            }
        }
        return result;
    }
}