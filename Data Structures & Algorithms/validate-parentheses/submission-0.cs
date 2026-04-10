public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
        var openParens = new Dictionary<char, char>() {
            {']', '['},
            {'}', '{'},
            {')', '('},
        };
        foreach (var c in s) {
            if (openParens.ContainsKey(c)) {
                if (stack.Count == 0) {
                    return false;
                }
                var top = stack.Pop();
                if (top != openParens[c]) {
                    return false;
                }
            } else {
                stack.Push(c);
            }
        }
        return stack.Count == 0;
    }
}
