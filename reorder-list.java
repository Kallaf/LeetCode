class Solution {
    public void reorderList(ListNode head) {
        List<ListNode> list = new ArrayList<ListNode>();
        while(head!=null)
        {
            list.add(head);
            ListNode next = head.next;
            head.next = null;
            head = next;
        }
        for(int i=0,j=list.size()-1;i<j;)
        {
            list.get(i++).next = list.get(j);
            if(i == j)break;
            list.get(j--).next = list.get(i);
        }
    }
}
