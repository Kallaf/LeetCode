public class Solution {
    public ListNode RemoveElements(ListNode head, int val) {
        while(head != null && head.val == val)
            head = head.next;
        if(head == null)
            return head;
        ListNode prev = head;
        ListNode it = head.next;
        while(it != null)
        {
            if(it.val == val)
                prev.next = it.next;
            else
                prev = it;
            
            it = it.next;
        }
        return head;
    }
}
