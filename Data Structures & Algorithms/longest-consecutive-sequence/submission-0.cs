public class Solution {
    public int LongestConsecutive(int[] nums) {
        var hashSet = new HashSet<int>(nums);
        var result = 0;
        foreach (var num in hashSet) {
            if (!hashSet.Contains(num - 1)) {
                int curr = num;
                int streak = 1;
                while (hashSet.Contains(curr + 1)) {
                    streak++;
                    curr++;
                }
                result = Math.Max(result, streak);
            }
        }
        return result;
    }
}
