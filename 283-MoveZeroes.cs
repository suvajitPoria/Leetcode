public class Solution {
    public void MoveZeroes(int[] nums) {
        int countZero = 0;
        int j = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] != 0)
            {
                nums[j] = nums[i];
                j++;
            }
        }
        for(int i = j; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }
}
