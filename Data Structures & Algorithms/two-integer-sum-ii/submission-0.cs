public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var used = new HashSet<int>();
        for (int i = 0; i < numbers.Length; i++) {
            if (used.Contains(i)) continue;
            used.Add(i);
            var left = i;
            var right = numbers.Length - 1;
            while (left < right) {
                var curr = numbers[left] + numbers[right];
                if (curr == target) {
                    return [left + 1, right + 1];
                } else if (curr < target)  {
                    left++;
                } else {
                    right--;
                }
            }
        }
        return [];
    }
}
