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
    vector<int> findMode(TreeNode* root) {
        if(!root)return ans;
        map<int,int> cnt;
        int mx = 0;
        queue<TreeNode*> q;
        q.push(root);
        while(!q.empty())
        {
            if(q.front()->left)q.push(q.front()->left);
            if(q.front()->right)q.push(q.front()->right);
            cnt[q.front()->val]++;
            mx = max(mx,cnt[q.front()->val]);
            q.pop();
        }
        for(pair<int,int> p:cnt)if(p.second == mx)ans.push_back(p.first);
        return ans;
    }
};
