public class Solution {
    public void Rotate(int[][] matrix) {
        int len = matrix[0].Length;
        int []arr = new int[len*len];
        int k = 0;
        for(int i = len-1; i >= 0; i--)
        {
            for(int j = 0; j<len; j++)
            {
                arr[k] = matrix[i][j];
                k++;
            }
        }
        k = 0;
        for(int i = 0; i < len; i++)
        {
            for(int j = 0; j<len; j++)
            {
                matrix[j][i] = arr[k];
                k++;
            }
        }
    }
}
