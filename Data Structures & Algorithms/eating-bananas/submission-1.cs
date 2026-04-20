public class Solution {
    public bool IsValid(int amount, int[] piles, int target) {
        int totalTime = 0;
        foreach (int pile in piles) {
            int hour = (int)Math.Ceiling((double)pile / amount);
            totalTime += hour;
        }

        return totalTime <= target;
    }

    public int MinEatingSpeed(int[] piles, int h) {
        int left = 1, right = piles.Max();
        int ans = 1;
        while (left <= right) {
            int mid = (left + right) / 2;
            Console.WriteLine($"left: {left}, right: {right}, mid: {mid}");
            if (IsValid(mid, piles, h)) {
                ans = mid;
                right = mid - 1;
            } else {
                left = mid + 1;
            }
        }

        return ans;
    }
}
