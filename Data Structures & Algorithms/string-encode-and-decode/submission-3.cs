public class Solution {
    private string _separator = "<#string#>";
    public string Encode(IList<string> strs) {
        var sb = new StringBuilder();
        foreach (string current in strs) {
            sb.Append(current);
            sb.Append(_separator);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        var arr = s.Split(_separator).ToList();
        if (arr.Count > 0) {
            arr.RemoveAt(arr.Count - 1);
        }
        return arr;
   }
}
