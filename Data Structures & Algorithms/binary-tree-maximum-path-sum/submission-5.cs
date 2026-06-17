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
    int max;
    public int MaxPathSum(TreeNode root) 
    {
        max = root.val;
        DFS(root);
        return max;
        //DFS find highest value 
        //Check child path vs
    }
    public int DFS(TreeNode root)
    {
        int leftmax = root.val;
        int rightmax = root.val;

        if(root.left != null)
        leftmax = root.val + DFS(root.left);
        if(root.right != null)
        rightmax = root.val + DFS(root.right);


        int localMax;
        localMax = root.val;
        localMax = Math.Max(localMax,leftmax + rightmax - root.val);
        localMax = Math.Max(localMax,leftmax);
        localMax = Math.Max(localMax,rightmax);


        max = Math.Max(max,localMax);
        Console.WriteLine($"Max: {max}");
        return(Math.Max(leftmax,Math.Max(rightmax,root.val)));
    }
}
