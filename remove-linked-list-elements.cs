/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RemoveElements(ListNode head, int val) {
        while(head != null && head.val == val){
            head = head.next;
        }
        if(head == null)return null;
        ListNode previous = head;
        ListNode temp = head.next;
        while(temp != null)
        {
            if(temp.val == val)
                previous.next = temp.next;
            else
                previous = temp;
            temp = previous.next;
        }
        return head;
    }
}
