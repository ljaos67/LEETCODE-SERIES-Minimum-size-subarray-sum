public class Solution {
    public int MinSubArrayLen(int target, int[] nums) 
    {
        if(nums.Length == 0)
        {
            return 0;
        }

        int subStart = 0;
        int index = 0;
        int sum = 0;
        int min = Int32.MaxValue;

        while(index < nums.Length)
        {
            sum += nums[index];
            index++;
            while(sum >= target)
            {
                min = Math.Min(min, index - subStart);
                sum -= nums[subStart];
                subStart++;
            }
        }
        return min == Int32.MaxValue ? 0 : min;
    }
}