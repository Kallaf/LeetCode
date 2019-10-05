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
    int target;
    int dfs(TreeNode* root,vector<int> parentsSum)
    {
        if(root == nullptr)return 0;
        int ans = 0;
        parentsSum.push_back(0);
        for(int i=0;i<parentsSum.size();i++)
        {
            parentsSum[i] += root->val;
            if(parentsSum[i] == target)ans++;
        }
        ans += dfs(root->left,parentsSum);
        ans += dfs(root->right,parentsSum);
        return ans;
    }
public:
    int pathSum(TreeNode* root, int sum) {
        target = sum;
        return dfs(root,vector<int>());
    }
};
