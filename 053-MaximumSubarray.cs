public class Solution {
    public int MaxSubArray(int[] nums) {
        int finalMax = nums[0];
        int currentSum = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] >= currentSum + nums[i])
            {
                currentSum = nums[i];
            }
            else
            {
                currentSum+=nums[i];
            }
            if(finalMax < currentSum)
            {
                finalMax = currentSum;
            }
        }
        return finalMax;
    }
}
