public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        int left = 0, right = (rows * cols) - 1;
        int mid = 0;
        int col = 0, row = 0;
        while (left <= right) {
            mid = (left + right) / 2;
            col = mid % cols;
            row = mid / cols;
            if (target == matrix[row][col]) {
                return true;
            } else if (target > matrix[row][col]) {
                left++;
            } else {
                right--;
            }
        }

        return false;
    }
}
