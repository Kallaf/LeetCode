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
    vector<vector<int>> paths;
    vector<int> path;
    int sum;
    void helper(TreeNode* root,vector<int>& path)
    {
        if(!root)return;
        sum -= root->val;
        path.push_back(root->val);
        if(!root->left && !root->right)
        {
            if(!sum)
                paths.push_back(path);
        }else{
            helper(root->left,path);
            helper(root->right,path);
        }
        sum += root->val;
        path.pop_back();
    }
public:
    vector<vector<int>> pathSum(TreeNode* root, int s) {
        vector<int> path;
        sum = s;
        helper(root,path);
        return paths;
    }
};
