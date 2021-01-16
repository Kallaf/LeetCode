class Solution {
    public ListNode addTwoNumbers(ListNode l1, ListNode l2) {
        return addTwoNumbersWithCarry(l1,l2,0);
    }
    
    public ListNode addTwoNumbersWithCarry(ListNode l1, ListNode l2,int carry) {
        if(l1 == null && l2 == null && carry == 0)return null;
        if(l1 == null)l1 = new ListNode();
        if(l2 == null)l2 = new ListNode();
        int val = l1.val + l2.val + carry;
        ListNode l3 = new ListNode(val%10);
        l3.next = addTwoNumbersWithCarry(l1.next,l2.next,val > 9 ? 1:0);
        return l3;
    }
}
