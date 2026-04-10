public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var stack = new Stack<int>();
        var n = temperatures.Length;
        var result = new int[n];
        for (int i = 0; i < temperatures.Length; i++) {
            var curr = temperatures[i];
            while (stack.Count > 0 && curr > temperatures[stack.Peek()]) {
                var index = stack.Pop();
                result[index] = (i - index);
            }
            stack.Push(i);
        }

        return result;
    }
}
