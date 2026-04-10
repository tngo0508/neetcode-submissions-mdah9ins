public class MinStack {
    private Stack<(int, int)> _stack;
    public MinStack() {
        _stack = new Stack<(int, int)>();
    }
    
    public void Push(int val) {
        var minVal = val;
        if (_stack.Count > 0) {
            var top = _stack.Peek().Item2;
            minVal = Math.Min(top, val);
        }
        _stack.Push((val, minVal));
    }
    
    public void Pop() {
        _stack.Pop();
    }
    
    public int Top() {
        return _stack.Peek().Item1;
    }
    
    public int GetMin() {
        return _stack.Peek().Item2;
    }
}
