double findMedianSortedArrays(int* nums1, int nums1Size, int* nums2, int nums2Size) {
    int len = nums1Size + nums2Size+1;
    int arr[len];
    int k=0;
    for(int i = 0; i < nums1Size;i++)
    {
        arr[k] = nums1[i];
        k++;
    }
     for(int i = 0; i < nums2Size;i++)
    {
        arr[k] = nums2[i];
        k++;
    }
    //sorting
    for(int i = 0; i < k-1; i++)
    {
        for(int j = i+1; j < k; j++)
        {
            if(arr[i] > arr[j])
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
    int mid = (0 + k-1) /2;
    if(k % 2 == 0)
    {
        return ((double)arr[mid] + (double)arr[mid+1]) / (double)2;
    }
    return arr[mid];
}
