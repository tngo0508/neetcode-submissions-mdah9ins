public class TimeMap {
    Dictionary<string, List<(int, string)>> TimeDict { get; set;}
    public TimeMap() {
        TimeDict = new();
    }
    
    public void Set(string key, string value, int timestamp) {
        if (!TimeDict.ContainsKey(key)) {
            TimeDict[key] = new List<(int, string)>();
        }
        TimeDict[key].Add((timestamp, value));
    }
    
    public string Get(string key, int timestamp) {
        if (!TimeDict.ContainsKey(key)) {
            return "";
        }
        var arr = TimeDict[key];
        int n = arr.Count;
        int left = 0, right = n - 1;
        string res = "";
        while (left <= right) {
            int mid = (left + right) / 2;
            if (arr[mid].Item1 <= timestamp) {
                res = arr[mid].Item2;
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }
        return res;
    }
}
