/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool FindTarget(TreeNode root, int k) {
        var hashSet = new HashSet<int>();
        //fazer dfs
        // a cada iteração tentar add valor - k
        // se consiguer segue dfs
        // se nao conseguir retorna true
        return DFS(root, k, hashSet);
    }

    public bool DFS(TreeNode node, int k,  HashSet<int> hashSet){
        if (node == null) return false;
        if (hashSet.Contains(node.val)) return true;
        hashSet.Add(k-node.val);

        var resultRight = DFS(node.right, k, hashSet);
        var resultLeft = DFS(node.left, k, hashSet);

        return resultRight || resultLeft;
    }
}
