public class Solution {
    public bool IsAnagram(string s, string t) {
        var dict = new Dictionary<char, int>();
        foreach (var c in s) {
            dict[c] = dict.GetValueOrDefault(c) + 1;
        }

        foreach(var c in t) {
            dict[c] = dict.GetValueOrDefault(c) - 1;
            if (dict[c] < 0)
                return false;
        }

        foreach(var kvp in dict) {
            if (kvp.Value != 0)
                return false;
        }
        return true;
    }
}
