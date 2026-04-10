public class Solution {
    public bool IsValidSudoku(char[][] board) {
        // 1. Validate rows, columns, and sub-boxes independently
        return IsRowValid(board) && IsColumnValid(board) && IsSubBoxValid(board);
    }

    private bool IsRowValid(char[][] board) {
        // 2. Iterate through each row and check for uniqueness
        for (int i = 0; i < 9; i++) {
            var seen = new HashSet<char>();
            for (int j = 0; j < 9; j++) {
                char curr = board[i][j];
                if (curr == '.') continue;
                
                if (seen.Contains(curr)) return false;
                seen.Add(curr);
            }
        }
        return true;
    }

    private bool IsColumnValid(char[][] board) {
        // 3. Iterate through each column and check for uniqueness
        for (int j = 0; j < 9; j++) {
            var seen = new HashSet<char>();
            for (int i = 0; i < 9; i++) {
                char curr = board[i][j];
                if (curr == '.') continue;
                
                if (seen.Contains(curr)) return false;
                seen.Add(curr);
            }
        }
        return true;
    }

    private bool IsSubBoxValid(char[][] board) {
        // 4. Use a dictionary of sets to track digits in each of the nine 3x3 boxes
        var boxes = new Dictionary<int, HashSet<char>>();
        for (int i = 0; i < 9; i++) boxes[i] = new HashSet<char>();

        for (int i = 0; i < 9; i++) {
            for (int j = 0; j < 9; j++) {
                char curr = board[i][j];
                if (curr == '.') continue;

                // Map the cell to one of the 9 sub-boxes (0-8)
                int boxIndex = (i / 3) * 3 + (j / 3);
                if (boxes[boxIndex].Contains(curr)) return false;
                boxes[boxIndex].Add(curr);
            }
        }
        return true;
    }
}