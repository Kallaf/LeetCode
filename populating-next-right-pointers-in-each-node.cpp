/*
// Definition for a Node.
class Node {
public:
    int val;
    Node* left;
    Node* right;
    Node* next;

    Node() {}

    Node(int _val, Node* _left, Node* _right, Node* _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
};
*/
class Solution {
public:
    Node* connect(Node* root) {
        if(root == nullptr)return nullptr;
        queue<Node*> q;
        q.push(root);
        while(!q.empty())
        {
            queue<Node*> temp;
            while(!q.empty())
            {
                Node* front = q.front();
                q.pop();
                if(!q.empty())front->next = q.front();
                if(front->left)temp.push(front->left);
                if(front->right)temp.push(front->right);
            }
            while(!temp.empty())
            {
                Node* front = temp.front();
                temp.pop();
                q.push(front);
            }
        }
        return root;
    }
};
