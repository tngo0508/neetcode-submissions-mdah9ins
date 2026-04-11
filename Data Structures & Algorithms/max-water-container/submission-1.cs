public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0;
        int right = heights.Length - 1;
        int res = 0;
        while (left < right) {
            int w = right - left;
            int h = Math.Min(heights[left], heights[right]);
            int area = w * h;
            res = Math.Max(res, area);
            if (heights[left] < heights[right]) {
                left++;
            } else {
                right--;
            }
        }

        return res;
    }
}
