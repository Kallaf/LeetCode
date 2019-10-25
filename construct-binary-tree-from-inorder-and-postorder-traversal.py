# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, x):
#         self.val = x
#         self.left = None
#         self.right = None

class Solution:
    def buildTree(self, inorder: List[int], postorder: List[int]) -> TreeNode:
        if not postorder:
            return None
        i = 0
        while inorder[i] != postorder[-1]:
            i += 1
        root = TreeNode(postorder[-1])
        root.left = self.buildTree(inorder[0:i],postorder[0:i])
        root.right = self.buildTree(inorder[i+1:],postorder[i:-1])
        
        return root
