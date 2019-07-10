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
    vector<vector<int>> levelOrderBottom(TreeNode* root) {
        vector<vector<int>> emptyV;
        if(!root)return emptyV;
        vector<vector<int>> left = levelOrderBottom(root->left);
        vector<vector<int>> right = levelOrderBottom(root->right);
        int small = left.size()<right.size() ? left.size():right.size();
        int large = left.size()>right.size() ? left.size():right.size();
        vector<vector<int>> current(large+1);
        for(int i=0;i<left.size();i++)
        {
            int x = left.size() == small?large-small:0;;
            for(int j=0;j<left[i].size();j++)
                current[i+x].push_back(left[i][j]);
        }
        for(int i=0;i<right.size();i++)
        {
            int x = right.size() == small?large-small:0;;
            for(int j=0;j<right[i].size();j++)
                current[i+x].push_back(right[i][j]);
        }   
        
        current[large].push_back(root->val);
        return current;
    }
};
