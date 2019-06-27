# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, x):
#         self.val = x
#         self.next = None

class Solution:
    def mergeTwoLists(self, l1: ListNode, l2: ListNode) -> ListNode:
        if not(l1 or l2):
            return None
        l3 = ListNode(0)
        header = l3
        while l1 or l2:
            if l1 and l2:
                if l1.val < l2.val:
                    header.val = l1.val
                    l1 = l1.next
                else:
                    header.val = l2.val
                    l2 = l2.next
            elif l1:
                header.val = l1.val
                l1 = l1.next
            else:
                header.val = l2.val
                l2 = l2.next
            if l1 or l2:
                header.next = ListNode(0)
                header = header.next
        return l3
                
                
