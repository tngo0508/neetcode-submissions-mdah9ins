public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        var cannotPlant = new HashSet<int>();
        for(int i = 0; i < flowerbed.Length; i++) {
            if (flowerbed[i] == 1) {
                cannotPlant.Add(i);
                cannotPlant.Add(i - 1);
                cannotPlant.Add(i + 1);
            }
        }
        for (int i = 0; i < flowerbed.Length; i++) {
            if (flowerbed[i] == 0 && !cannotPlant.Contains(i)) {
                n -= 1;
                cannotPlant.Add(i);
                cannotPlant.Add(i + 1);
                cannotPlant.Add(i - 1);
            }
        }

        return n <= 0;
    }
}