def invert_tree(root)
    return root if root.nil?
    root.right ,root.left = invert_tree(root.left),invert_tree(root.right);
    return root;
end
