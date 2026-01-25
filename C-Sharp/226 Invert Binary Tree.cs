public class Solution
{
    public TreeNode InvertTree(TreeNode root)
    {
        if (root == null) return root;
        if (root.left == null && root.right == null) return root;

        return DFS(root);
    }
    public TreeNode DFS(TreeNode node)
    {
        if (node == null) return null;

        var tempNode = node.right;
        node.right = node.left;
        node.left = tempNode;

        DFS(node.right);
        DFS(node.left);

        return node;
    }
}
