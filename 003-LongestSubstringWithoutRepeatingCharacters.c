int lengthOfLongestSubstring(char* s) {
    int len = strlen(s);
    int arr[len+1];
    int i = 0,j;
    for(i; i < len; i++)
    {
        arr[i]=0;
        for(j=i;j<len;j++)
        {
            bool temp = true;
            for(int k = i; k<j; k++  )
            {
                if(s[j] != s[k])
                {
                    temp = true;
                }
                else
                {
                    temp = false;
                    break;
                }
            } 
            if(temp)
            {
                arr[i]++;
            }  
            else
            {
                break;
            }
        }
    }
    int max = arr[0];
    for(int p = 0;  p < len; p++)
    {
        if(max<arr[p])
        {
            max = arr[p];
        }
    }
    return max;
}
