public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
       for(int i = 0; i < matrix.Length; i++)
       {
            if(matrix[i][0] <= target && target <= matrix[i][matrix[i].Length - 1])
            {
                for(int j = 0; j < matrix[i].Length; j++)
                {
                    if(matrix[i][j] == target)
                    {
                        return true;
                    }
                }   
            }
       } 
       return false;
    }
}
