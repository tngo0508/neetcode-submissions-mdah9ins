public class Solution {
    public int Trap(int[] height) {
        int n = height.Length;
        int res = 0;
        int[] leftArr = new int[n];
        int currHeight = 0;
        for (int i = 0; i < n; i++) {
            currHeight = Math.Max(currHeight, height[i]);
            leftArr[i] = currHeight;
        }
        Console.WriteLine(string.Join(", ", leftArr));
        currHeight = 0;
        for (int i = n - 1; i >= 0; i--) {
            currHeight = Math.Max(currHeight, height[i]);
            res += (Math.Min(leftArr[i], currHeight) - height[i]);
        }
        return res;
    }
}
