public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int row = 0;

        int l = 0;
        int r = matrix.Length - 1;

        while (l <= r)  {
            int m = (l + r) / 2;
            if (target < matrix[m][0]) {
                r = m  - 1;
            }
            else if (target > matrix[m][matrix[m].Length - 1])  {
                l = m + 1;
            }
            else {
                row = m;
                break;
            }
            row = m;
        }

        l = 0; r = matrix[row].Length - 1;
        while (l <= r) {
            int m = (l + r) / 2;
            if (matrix[row][m] < target)
            {                l = m + 1;
            }
            else if (matrix[row][m] > target)
            {                r = m - 1;
            }
            else
            {                return true;
            }
        }

        return false;

    }
}
