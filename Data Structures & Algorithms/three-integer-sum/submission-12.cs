public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var result = new List<List<int>>();
        var n = nums.Length;
        for (int i = 0; i < nums.Length; i++) {
            if (i > 0 && nums[i] == nums[i-1]) continue;
            int index = i;
            int left = i + 1;
            int right = n - 1;
            while (left < right) {
                var currVal = nums[left] + nums[right];
                if (currVal == -nums[index]) {
                    result.Add(new List<int> {nums[index], nums[left], nums[right]});
                    left++;
                    right--;
                    
                    while (left < right && nums[left] == nums[left - 1]) {
                        left++;
                    }

                    while (left < right && nums[right] == nums[right + 1]) {
                        right--;
                    }
                } else if (currVal > -nums[index]) {
                    right--;
                } else {
                    left++;
                }
            }
        }

        return result;
    }
}