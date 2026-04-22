public class Solution {
    public int FindMin(int[] nums) {
        int n = nums.Length;
        int left = 0, right = n - 1;
        int res = int.MaxValue;
        while (left <= right) {
            int mid = (left + right) / 2;
            if (nums[left] <= nums[mid]) {
                res = Math.Min(res, nums[left]);
                left = mid + 1;
            } else {
                res = Math.Min(res, nums[mid]);
                right = mid - 1;
            }
        }

        return res;
    }
}
