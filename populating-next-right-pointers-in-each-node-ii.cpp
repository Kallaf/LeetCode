/*
// Definition for a Node.
class Node {
public:
    int val;
    Node* left;
    Node* right;
    Node* next;

    Node() : val(0), left(NULL), right(NULL), next(NULL) {}

    Node(int _val) : val(_val), left(NULL), right(NULL), next(NULL) {}

    Node(int _val, Node* _left, Node* _right, Node* _next)
        : val(_val), left(_left), right(_right), next(_next) {}
};
*/
class Solution {
public:
    Node* connect(Node* root) {
        if(!root)return root;
        Node* child = root->left;
        if(child && root->right)
            child->next = root->right;
        if(root->right)child = root->right;
        Node* parent = root->next;
        if(child)
        {
            while(parent)
            {
                if(parent->left)
                {
                    child->next = parent->left;
                    break;
                }
                if(parent->right)
                {
                    child->next = parent->right;
                    break;
                }
                parent = parent->next;
            }
        }
        root->right = connect(root->right);
        root->left = connect(root->left);
        return root;
    }
};
