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
public:
    int minDepth(TreeNode* root) {
        if(!root)return 0;
        int ld = minDepth(root->left);
        int rd = minDepth(root->right);
        if(ld == 0)return rd+1;
        if(rd == 0)return ld+1;
        return min(ld,rd)+1;
    }
};
