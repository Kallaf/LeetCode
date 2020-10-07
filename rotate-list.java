class Solution {
    public ListNode rotateRight(ListNode head, int k) {
        if(head == null) return null;
        int count = 1;
        ListNode it = head;
        while(it.next != null)
        {
            it = it.next;
            count++;
        }
        int idx = count - (k%count);
        if(idx != count)
        {
            it.next = head;
            it = head;
            for(int i=1;i<idx;i++)
            {
                it = it.next;
            }
            head = it.next;
            it.next = null;
        }
        return head;
    }
}
