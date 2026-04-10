public class Solution {
    public string Encode(IList<string> strs) {
        var separator = "<#string#>";
        var sb = new StringBuilder();
        for (int i = 0; i < strs.Count; i++) {
            string currentStr = strs[i];
            sb.Append(currentStr);
            sb.Append(separator);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        var separator = "<#string#>";
        var arr = s.Split(separator).ToList();
        if (arr.Count > 0) {
            arr.RemoveAt(arr.Count - 1);
        }
        return arr;
   }
}
