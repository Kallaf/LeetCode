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
    bool isSymmetric(TreeNode* root) {
        queue<TreeNode*> q;
        q.push(root);
        q.push(root);
        while(!q.empty())
        {
            TreeNode* n1 = q.front();q.pop();
            TreeNode* n2 = q.front();q.pop();
            if(n1 == nullptr && n2 == nullptr)continue;
            if(n1 == nullptr || n2 == nullptr)return false;
            if(n1->val != n2->val)return false;
            q.push(n1->left);q.push(n2->right);
            q.push(n1->right);q.push(n2->left);
        }
        return true;
    }
};
