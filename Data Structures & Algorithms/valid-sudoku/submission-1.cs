public class Solution {
    public bool IsRowValid(char[][] board) {
        for (int i = 0; i < board.Length; i++) {
            var seen = new HashSet<char> ();
            for (int j = 0; j < board.Length; j++) {
                var curr = board[i][j];
                if (curr == '.') continue;
                if (seen.Contains(curr)) {
                    return false;
                }
                seen.Add(curr);
            }
        }
        return true;
    }

    public bool IsColumnValid(char[][] board) {
        for (int j = 0; j < board.Length; j++) {
            var seen = new HashSet<char> ();
            for (int i = 0; i < board.Length; i++) {
                var curr = board[i][j];
                if (curr == '.') continue;
                if (seen.Contains(curr)) {
                    return false;
                }
                seen.Add(curr);
            }
        }
        return true;
    }

    public bool IsSubBoxValid(char[][] board) {
        var seen = new Dictionary<int, HashSet<int>>{
            {0, new HashSet<int>()},
            {1, new HashSet<int>()},
            {2, new HashSet<int>()},
            {3, new HashSet<int>()},
            {4, new HashSet<int>()},
            {5, new HashSet<int>()},
            {6, new HashSet<int>()},
            {7, new HashSet<int>()},
            {8, new HashSet<int>()},
        };
        for (int i = 0; i < board.Length; i++) {
            for (int j = 0; j < board.Length; j++) {
                var curr = board[i][j];
                if (curr == '.') continue;
                int groupNum = i / 3 * 3 + j / 3;
                int currNum = board[i][j] - '0';
                if (seen[groupNum].Contains(currNum)) {
                    return false;
                }

                seen[groupNum].Add(currNum);
            }
        }
        return true;
    }

    public bool IsValidSudoku(char[][] board) {
        return IsRowValid(board) && IsColumnValid(board) && IsSubBoxValid(board);
    }
}