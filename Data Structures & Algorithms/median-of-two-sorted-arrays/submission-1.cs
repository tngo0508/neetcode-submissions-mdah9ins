public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int n1 = nums1.Length;
        int n2 = nums2.Length;
        
        // Ensure nums1 is the smaller array
        if (n1 > n2) return FindMedianSortedArrays(nums2, nums1);
        
        int low = 0, high = n1;
        int totalLeft = (n1 + n2 + 1) / 2;
        
        while (low <= high) {
            int i = (low + high) / 2; // Partition index for nums1
            int j = totalLeft - i;    // Partition index for nums2
            
            int left1 = (i > 0) ? nums1[i - 1] : int.MinValue;
            int right1 = (i < n1) ? nums1[i] : int.MaxValue;
            
            int left2 = (j > 0) ? nums2[j - 1] : int.MinValue;
            int right2 = (j < n2) ? nums2[j] : int.MaxValue;
            
            if (left1 <= right2 && left2 <= right1) {
                // Correct partition found
                if ((n1 + n2) % 2 == 1) {
                    return Math.Max(left1, left2);
                }
                return (Math.Max(left1, left2) + Math.Min(right1, right2)) / 2.0;
            }
            else if (left1 > right2) {
                high = i - 1;
            }
            else {
                low = i + 1;
            }
        }
        
        return 0.0;
    }
}