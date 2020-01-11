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
    int previous = -1,ans = INT32_MAX;
    void inorder(TreeNode* root)
    {
        if(root == nullptr)return;
        inorder(root->left);
        if(previous!=-1)ans = min(ans,root->val - previous);
        previous = root->val;
        inorder(root->right);
    }
public:
    int getMinimumDifference(TreeNode* root) {
        inorder(root);
        return ans;
    }
};
