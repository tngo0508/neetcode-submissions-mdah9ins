public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var length = nums.Length;
        var left = new int[length + 1];
        var right = new int[length + 1];
        var result = new int[length];
        Array.Fill(left, 1);
        Array.Fill(right, 1);
        for (var i = 1; i < length + 1; i++) {
            left[i] = left[i - 1] *  nums[i - 1];
        }
        for (var i = length - 1; i >= 0; i--) {
            right[i] = right[i + 1] * nums[i];
        }

        for (var i = 0; i < length; i++) {
            result[i] = left[i] * right[i + 1];
        }
        return result;
    }
}
