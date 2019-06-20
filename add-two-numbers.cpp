/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode(int x) : val(x), next(NULL) {}
 * };
 */
class Solution {
public:
    ListNode* addTwoNumbers(ListNode* l1, ListNode* l2) {
        int reminder = 0;
        ListNode* sumNode = new ListNode((reminder+l1->val+l2->val)%10);
        ListNode* temp = sumNode;
        reminder = (reminder+l1->val%10+l2->val%10)/10;
        l1 = l1->next;l2=l2->next;
        while(l1 && l2)
        {
            temp->next = new ListNode((reminder+l1->val+l2->val)%10);
            reminder = (reminder+l1->val%10+l2->val%10)/10;
            l1 = l1->next;l2=l2->next;
            temp = temp->next;
        }
        
        while(l1)
        {
            temp->next = new ListNode((reminder+l1->val)%10);
            reminder = (reminder+l1->val)/10;
            l1 = l1->next;
            temp = temp->next;
        }
        
        while(l2)
        {
            temp->next = new ListNode((reminder+l2->val)%10);
            reminder = (reminder+l2->val)/10;
            l2 = l2->next;
            temp = temp->next;
        }
        
        if(reminder)temp->next = new ListNode(reminder);
        
        return sumNode;
    }
};
