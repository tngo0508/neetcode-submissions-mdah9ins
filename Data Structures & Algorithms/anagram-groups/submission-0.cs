public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var result = new List<List<string>>();
        var dict = new Dictionary<string, List<string>>();
        foreach(var currString in strs) {
            var key = new string(currString.OrderBy(c => c).ToArray());
            // Console.WriteLine(key);
            if (!dict.TryGetValue(key, out var existing)) {
                existing = new List<string>();
                dict[key] = existing;
            }
            existing.Add(currString);
        }
        // Console.WriteLine(string.Join(", ", dict.Select(kvp => $"[{kvp.Key.ToString()}], [{string.Join(", ", kvp.Value)}]")));
        return new List<List<string>>(dict.Values);
    }
}
