/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode(int x) : val(x), next(NULL) {}
 * };
 */
/**
 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     TreeNode *left;
 *     TreeNode *right;
 *     TreeNode(int x) : val(x), left(NULL), right(NULL) {}
 * };
 */
class Solution {
private:
    
    int size;
    ListNode* head;
    int getSize()
    {
        ListNode* ptr = head;
        int len = 0;
        for(;ptr;ptr=ptr->next,len++);
        return len;
    }
    TreeNode* convert(int l,int r)
    {
        if(l>r)return NULL;
        int mid = l + (r-l)/2;
        TreeNode* left = convert(l,mid - 1);
        TreeNode* node = new TreeNode(head->val);
        node->left = left;
        head = head->next;
        node->right = convert(mid+1,r);
        return node;
    }
    
public:
    TreeNode* sortedListToBST(ListNode* hd) {
        head = hd;
        int size = getSize();
        return convert(0,size-1);
    }
};
