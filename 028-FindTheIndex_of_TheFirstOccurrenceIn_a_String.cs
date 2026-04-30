public class Solution {
    public int StrStr(string haystack, string needle) {
        if (haystack.Length >= needle.Length)
        {
            char[] arr = haystack.ToCharArray();
            char[] arr2 = needle.ToCharArray();

            for (int i = 0; i <= arr.Length - arr2.Length; i++) 
            {
                int j = 0;

                while (j < arr2.Length && arr[i + j] == arr2[j]) 
                {
                    j++;
                }

                if (j == arr2.Length) 
                {
                    return i;
                }
            }
        }
        return -1;
    }
}
