public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        for(int i = m ,j = 0; i < m + n; i++,j++)
        {
            nums1[i] = nums2[j];
        }
        nums1 = Sorting(nums1,m+n);
    }
    private int[] Sorting(int[] arr, int n)
    {
        for(int i = 0; i < n-1; i++)
        {
            for(int j = i+1; j < n; j++)
            {
                if(arr[i] > arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        return arr;
    }
}
