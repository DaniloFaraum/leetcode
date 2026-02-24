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
public class FirstSolution {
    int sum = 0;

    public int SumRootToLeaf(TreeNode root) {
        if (root == null) return 0;
        if (root.left == null && root.right == null) return root.val;

        var binary = new StringBuilder();

        DFS(root, binary);
        return sum;
    }

    public void DFS(TreeNode node, StringBuilder binary){
        if (node == null) return;
        binary.Append(node.val.ToString());
        if (node.left == null && node.right == null){
            var binaryString = binary.ToString();
            Console.WriteLine(binaryString);
            Console.WriteLine(sum);
            sum += Convert.ToInt32(binaryString, 2);
        }
        DFS(node.left, binary);
        DFS(node.right, binary);
        binary.Length--;
    }
}

public class Solution {
    public int SumRootToLeaf(TreeNode root) {
        return CalculateSum(root, 0);
    }   

    private int CalculateSum(TreeNode node, int currentSum) {
        if (node == null) return 0;

        currentSum = (currentSum << 1) | node.val; // bitwise operators

        if (node.left == null && node.right == null) {
            return currentSum;
        }
        
        return CalculateSum(node.left, currentSum) + CalculateSum(node.right, currentSum);
    }
}
