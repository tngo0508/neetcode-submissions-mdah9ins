public class Solution {
    public bool isConsecutive(int[] nums) {
        var x = nums.Min();
        var n = nums.Length;
        var hs = new HashSet<int>(nums);
        for(int i = x; i < x + n; i++) 
        {
            if (!hs.Contains(i))
                return false;
        }
        return true;
    }
}
