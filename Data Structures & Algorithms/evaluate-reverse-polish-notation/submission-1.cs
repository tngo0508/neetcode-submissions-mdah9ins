public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<int>();
        foreach(var token in tokens) {
            if (int.TryParse(token, out int digit)) {
                stack.Push(digit);
            } else {
                if (stack.Count >= 2) {
                    var y = stack.Pop();
                    var x = stack.Pop();
                    switch (token) {
                        case "+":
                            stack.Push(x + y);
                            break;
                        case "-":
                            stack.Push(x - y);
                            break;
                        case "*":
                            stack.Push(x * y);
                            break;
                        case "/":
                            stack.Push(x / y);
                            break;
                    }
                }
            }
        }

        return stack.Pop();
    }
}
