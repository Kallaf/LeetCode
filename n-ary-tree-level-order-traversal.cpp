/*
// Definition for a Node.
class Node {
public:
    int val;
    vector<Node*> children;

    Node() {}

    Node(int _val, vector<Node*> _children) {
        val = _val;
        children = _children;
    }
};
*/
class Solution {
private:
    void helper(Node* root,int depth,vector<vector<int>>& ans)
    {
        if(root == NULL)return;
        vector<int> row;
        if(depth == ans.size())ans.push_back(row);
        ans[depth].push_back(root->val);
        for(Node* child:root->children)
            helper(child,depth+1,ans);
    }
    
public:
    vector<vector<int>> levelOrder(Node* root) {
        vector<vector<int>> ans;
        helper(root,0,ans);
        return ans;
    }
};
