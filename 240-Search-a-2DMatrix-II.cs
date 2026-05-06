public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int i = 0;                          
        int j = matrix[0].Length - 1;       

        while(i < matrix.Length && j >= 0)
        {
            if(matrix[i][j] == target)
            {
                return true;
            }
            else if(matrix[i][j] > target)
            {
                j--; 
            }
            else
            {
                i++; 
            }
        }

        return false;
    }
}
