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
    vector<vector<int>> zigzagLevelOrder(TreeNode* root) {
        if(!root)return {};
        vector<vector<int>> res;
        deque<TreeNode*> q{{root}};
        bool flag = 0;
        while(!q.empty())
        {
            vector<int> row;
            if(!flag)
            for(int i=q.size();i>0;i--)
            {
                TreeNode *t = q.front();q.pop_front();
                row.push_back(t->val);
                if(t->left)q.push_back(t->left);
                if(t->right)q.push_back(t->right);
            }else
            {
                for(int i=q.size();i>0;i--)
                {
                    TreeNode *t = q.back();q.pop_back();
                    row.push_back(t->val);
                    if(t->right)q.push_front(t->right);
                    if(t->left)q.push_front(t->left);
                }
            }
            flag ^= 1;
            res.push_back(row);
        }
        return res;
    }
};
