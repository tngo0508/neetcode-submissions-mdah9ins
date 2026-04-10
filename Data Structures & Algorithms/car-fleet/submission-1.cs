public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        List<(int, int)> arr = new List<(int, int)>();
        for (int i = 0; i < speed.Length; i++) {
            arr.Add((position[i], speed[i]));
        }
        var sortedArr = arr.OrderByDescending(x => x.Item1).ToList();
        var stack = new Stack<double>();
        for (int i = 0; i < sortedArr.Count; i++) {
            var (pos, curr) = sortedArr[i];
            double time = (double)(target - pos) / curr;
            if (stack.Count > 0 && stack.Peek() >= time)
                continue;
            stack.Push(time);
        }

        return stack.Count;
    }
}
