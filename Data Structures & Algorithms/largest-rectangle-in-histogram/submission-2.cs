public class Solution {
    public int FindArea(int i, int[] heights, int length) {
        int currHeight = heights[i];
        int left = i, right = i;
        while (left >= 0 && heights[left] >= currHeight) {
            left--;
        }
        while (right < length && heights[right] >= currHeight) {
            right++;
        }
        return currHeight * (right - left - 1);
    }

    public int LargestRectangleArea(int[] heights) {
        int N = heights.Length;
        int res = 0;
        for (int i = 0; i < N; i++) {
            if (heights[i] == 0) continue;
            int currArea = FindArea(i, heights, N);
            res = Math.Max(res, currArea);
        }
        return res;
    }
}