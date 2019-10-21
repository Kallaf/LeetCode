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
    void helper(int depth,vector<vector<int>>& ans,TreeNode* root)
    {
        if(root == nullptr)return;
        if(ans.size() == depth)
            ans.push_back(vector<int>());
        ans[depth].push_back(root->val);
        helper(depth+1,ans,root->left);
        helper(depth+1,ans,root->right);
    }
public:
    vector<vector<int>> levelOrder(TreeNode* root) {
        vector<vector<int>> ans;
        helper(0,ans,root);
        return ans;
    }
};
