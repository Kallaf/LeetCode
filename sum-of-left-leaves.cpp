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
    int helper(TreeNode* root,bool isLeft)
    {
        if(root->left == NULL && root->right == NULL)return isLeft?root->val:0;
        int sum = root->left ? helper(root->left,true):0;
        sum += root->right ? helper(root->right,false):0;
        return  sum;
    }
public:
    int sumOfLeftLeaves(TreeNode* root) {
        if(!root)return 0;
        return helper(root,false);
    }
};
