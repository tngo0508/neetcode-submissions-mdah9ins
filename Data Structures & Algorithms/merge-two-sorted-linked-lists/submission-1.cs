/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
 
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode sentinel = new ListNode(-1);
        var head = sentinel;
        var l1 = list1;
        var l2 = list2;
        while (l1 != null && l2 != null) {
            if (l1.val <= l2.val) {
                head.next = new ListNode(l1.val);
                l1 = l1.next;
            } else {
                head.next = new ListNode(l2.val);
                l2 = l2.next;
            }
            Console.WriteLine(head.val);
            head = head.next;
        }

        while (l1 != null) {
            head.next = new ListNode(l1.val);
            l1 = l1.next;
            head = head.next;
        }

        while (l2 != null) {
            head.next = new ListNode(l2.val);
            l2 = l2.next;
            head = head.next;
        }

        return sentinel.next;
    }
}