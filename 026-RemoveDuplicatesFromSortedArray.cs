public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int k = 1;
       for(int i = 0; i< nums.Length; i++)
       {
        int j;
          for(j = i+1; j < nums.Length; j++)
          {
            if(nums[i] < nums[j])
            {
                nums[i+1] = nums[j];
                k++;
                break;
            }
          }
          if(j == nums.Length)
          {
            break;
          }
       }
       return k;
    }
   
}
