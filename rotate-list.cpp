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
    ListNode* rotateRight(ListNode* head, int k) {
        if(!head)return NULL;
        vector<int> arr;
        while(head)
        {
            arr.push_back(head->val);
            head = head->next;
        }
        vector<int> shifted;
        int n = arr.size();
        for(int i=0;i<n;i++)
            shifted.push_back(arr[(n+i-(k%n))%n]);
        ListNode* shifted_head;
        ListNode* temp = new ListNode(shifted[0]);
        shifted_head = temp;
        for(int i=1;i<n;i++)
        {
            ListNode* next = new ListNode(shifted[i]);
            temp->next = next;
            temp = temp->next;
        }
        return shifted_head;
    }
};
