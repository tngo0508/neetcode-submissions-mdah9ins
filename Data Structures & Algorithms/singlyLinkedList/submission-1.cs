public class LinkedList {
    private List<int> _list;
    public LinkedList() {
        _list = new();
    }

    public int Get(int index) {
        if (index >= _list.Count || index < 0) return -1;
        return _list[index];
    }

    public void InsertHead(int val) {
        _list.Insert(0, val);
    }

    public void InsertTail(int val) {
        _list.Add(val);
    }

    public bool Remove(int index) {
        if (index >= _list.Count || index < 0) return false;
        _list.RemoveAt(index);
        return true;
    }

    public List<int> GetValues() {
        return _list;
    }
}