public class Solution {
    public int SearchInsert(int[] nums, int target) {

        if(nums.Length == 1)
        {
            if(target == nums[0])
            {
                return 0;
            }
            else if(target > nums[0])
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        return Search(nums,0,nums.Length-1,target);

    }
    private int Search(int[] nums, int low, int high, int target)
    {
        int mid = (high+low)/2;
        if(nums[mid] == target)
        {
            return mid;
        }
        else if(nums[mid] < target)
        {
            if(high - low == 1)
            {
                if(target>nums[high])
                {
                    return high+1;
                }
                return high;
            }
            
            else
            {
                return Search(nums,mid,high,target);
            }
        }
        else
        {
            if(high - low == 1)
            {
                if(target>nums[low])
                {
                    return high;
                }
                return low;
            }
            else
            {
                return Search(nums, low, mid,target);
            }
        }
    }
}
