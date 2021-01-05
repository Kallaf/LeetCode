class Solution {
    public ListNode deleteDuplicates(ListNode head) {
        if(head == null)return null;
        ListNode it = head.next;
        while(it != null && it.val == head.val)it = it.next;
        if(it!=head.next)return deleteDuplicates(it);
        head.next = deleteDuplicates(head.next);
        return head;
    }
}
