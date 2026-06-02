/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        Dictionary<Node, Node> cloneDict = new Dictionary<Node, Node>();
        Node curr = head;
        Node dummy = new Node(-1);
        Node ptr = dummy;
        while (curr != null) {
            Node newNode = new Node(curr.val);
            cloneDict[curr] = newNode;
            ptr.next = newNode;
            ptr = newNode;
            curr = curr.next;
        }
        curr = head;
        while (curr != null) {
            if (curr.random != null)
                cloneDict[curr].random = cloneDict[curr.random];
            curr = curr.next;
        }

        return dummy.next;
    }
}
