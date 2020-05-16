public class Solution {
    public ListNode OddEvenList(ListNode head) {
        if(head == null)return head;
        ListNode evenHead = head.next;
        ListNode oddTail = head;
        ListNode it = head;
        for(int i=0;it != null;i++)
        {
            if(i%2 == 0)
                oddTail = it;
            ListNode next = it.next;
            if(next != null)it.next = next.next;
            else it.next = null;
            it = next;
        }
        oddTail.next = evenHead;
        return head;
    }
}
