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
    bool helper(TreeNode* root,int &h)
    {
        if(!root)return true;
        int lh,rh;lh = rh = h;
        bool lf = helper(root ->left,lh);
        if(!lf)return false;
        bool rt = helper(root ->right,rh);
        if(!rt)return false;
        h = max(lh,rh)+1;
        return {abs(lh-rh) <= 1};
    }
public:
    bool isBalanced(TreeNode* root) {
        int h = 0;
        return helper(root,h);
    }
};
