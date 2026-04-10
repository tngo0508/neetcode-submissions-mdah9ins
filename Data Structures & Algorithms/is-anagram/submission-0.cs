public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] arr = Enumerable.Range(1, 26).ToArray();
        Array.Fill(arr, 0);
        foreach(var c in s) {
            int index = c - 'a';
            arr[index] += 1;
        }
        foreach(var c in t) {
            int index = c - 'a';
            arr[index] -= 1;
        }
        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] != 0) return false;
        }

        return true;
    }
}
