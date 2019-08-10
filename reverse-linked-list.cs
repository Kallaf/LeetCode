/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode newHead = null;
        ListNode curr = head;
        while(curr != null)
        {
            ListNode temp = curr.next;
            curr.next = newHead;
            newHead = curr;
            curr = temp;
        }
        return newHead;
    }
}
