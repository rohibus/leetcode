public class Solution {
    public int MinSubArrayLen(int target, int[] nums) 
    {
        int sum = 0;
        int min = Int32.MaxValue;
        int left = 0;
        int right = 0;
        
        while (right < nums.Length)
        {
            sum += nums[right];
            right++;
            
            while (right < nums.Length && sum < target)
            {
                sum += nums[right];
                right++;
            }
            
            if (right <= nums.Length && sum >= target)
            {
                min = Math.Min(min, right - left);
                
                while (left < right && sum > target)
                {
                    sum -= nums[left];
                    left++;
                    
                    if (sum >= target)
                        min = Math.Min(min, right - left);
                }
            }
        }
        
        return min == Int32.MaxValue ? 0 : min;
    }
}
