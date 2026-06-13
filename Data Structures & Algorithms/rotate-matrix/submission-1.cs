public class Solution {
    public void Rotate(int[][] matrix) 
    {
        int left = 0;
        int right = matrix[0].Length-1;

        while (left < right)
        {
            for(int i = 0; i < right-left; i++)
            {
                int tl = matrix[left][left+i];
                int tr = matrix[left+i][right];
                int bl = matrix[right-i][left];
                int br = matrix[right][right-i];

                matrix[left][left+i] = bl;
                matrix[left+i][right] = tl;
                matrix[right-i][left] = br;
                matrix[right][right-i] = tr;
                
            }
            left++;
            right--;
        }

    }
}
