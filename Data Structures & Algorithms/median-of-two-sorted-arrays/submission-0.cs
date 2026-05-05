public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int len1 = nums1.Length;
        int len2 = nums2.Length;
        int length = len1 + len2;
        int[] arr = new int[length];
        int i = 0, j = 0, k = 0;
        while (i < len1 && j < len2) {
            if (nums1[i] <= nums2[j]) {
                arr[k] = nums1[i];
                i++;
            } else {
                arr[k] = nums2[j];
                j++;
            }
            k++;
        }
        while (i < len1) {
            arr[k] = nums1[i];
            i++;
            k++;
        }
        while (j < len2) {
            arr[k] = nums2[j];
            j++;
            k++;
        }
        int mid = k / 2;
        int isOdd = (len1 + len2) % 2;
        if (isOdd > 0) {
            return arr[mid];
        }
        return (double)(arr[mid] + arr[mid - 1]) / 2;
    }
}
