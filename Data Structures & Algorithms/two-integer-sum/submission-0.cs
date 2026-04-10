public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] result = new int[2];
        Dictionary<int, int> seen = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            if (seen.ContainsKey(complement)) {
                return new int[] { seen[complement], i };
            }

            if (!seen.TryGetValue(nums[i], out var existing)) {
                seen[nums[i]] = i;
            }
        }

        return result;
    }
}
