public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0, r = nums.Length - 1;
        while (l <= r) {
            int mid = l + (r - l) / 2;
            if (nums[mid] == target) {
                return mid;
            } else if (nums[mid] < target) {
                l++;
            } else {
                r--;
            }
        }
        return -1;
    }
}
