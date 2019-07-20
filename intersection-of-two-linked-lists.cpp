/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        HashSet<ListNode> nodes = new HashSet<ListNode>();
        while(headA != null && headB != null)
        {
            if (nodes.Contains(headA))return headA;
            if (nodes.Contains(headB))return headB;
            if(headA == headB)return headA;
            nodes.Add(headA);
            nodes.Add(headB);
            headA = headA.next;
            headB = headB.next;
        }
        
        while(headA != null)
        {
            if (nodes.Contains(headA))return headA;
            nodes.Add(headA);
            headA = headA.next;
        }
        
        while(headB != null)
        {
            if (nodes.Contains(headB))return headB;
            nodes.Add(headB);
            headB = headB.next;
        }
        return null;
    }
}
