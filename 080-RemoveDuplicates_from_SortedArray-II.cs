public class Solution {
    public int RemoveDuplicates(int[] nums) {
       int putIndex = 0;
       int count = 0;
       int element = nums[0];
       for(int i = 1; i < nums.Length; i++)
       {
           if(nums[i] == element)
           {
               count++;
               if(count <= 1)
               {
                   putIndex++;
               }
               nums[putIndex] = nums[i];   
           }
           else 
           {
               putIndex ++;
               nums[putIndex] = nums[i];
               count = 0;
           }
           element = nums[i];
       }
       return putIndex+1;
    }
}