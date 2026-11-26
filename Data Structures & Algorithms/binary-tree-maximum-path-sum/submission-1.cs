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
        must need max path sum of any non-empty path?

        a path in a BT is a sequeunce of nodes where each pair of 
        adj nodes has an edge connecting them, a node appears only once

        path does not need to include the root

        path sum is the sum of the nodes values in a path.

        example 1 -> 2 1 3 add the nodes values

        ex 2 
        the answer is 15 -> 20 -> 5 since it is the max path valye 

        other paths exist but they arent the highest

        we need to check if the left and right nodes are null that is an edge case

        we check the current best path

        which is left + root + right that will the max value 

        then we dfs down and for each node we check this cond

        we then return the value and take the max if it is more than the curr
        value that we have it will be the new value.

        and then we return the maximum value that exists

        but we also need to consider traveling up as well

        since a path could be leftchild + parent + Granparent

        we need to pass in the value upwards as well and check the path

        the saem check matters we just need to make sure taht the maximum is also considered.

        Solution: 

        we check the current path value the left + current + right 

        but we only accept if that is higher than the max


public class Solution {
    int maxPathSum = int.MinValue; Global Value
    public int MaxPathSum(TreeNode root) {

        _= CurrentPathGain(root);
        return maxPathSum
    }

    public int CurrentPathGain(TreeNode root){
     int currentPathGain = 0;
     int leftGain = 0;
     int rightGain = 0;
       if(root == null) return 0;

       if(root.left != null)   leftGain = Math.Max(0,CurrentPathGain(root.left)); 
       if(root.right != null)  rightGain = Math.Max(0,CurrentPathGain(root.right)); 
       
       currentPathGain = root.val + Math.Max(leftGain, rightGain);

       maxPathSum = Math.Max(maxPathSum, leftGain + root.val + rightGain);


      return currentPathGain;
    }
}



 */

public class Solution {

    int maxPathSum = int.MinValue;//remember this for negative Values
    public int MaxPathSum(TreeNode root) {

        _= CurrentPathGain(root);
        return maxPathSum; 
    }

    public int CurrentPathGain(TreeNode root){
        int leftGain = 0;
        int rightGain = 0;
        int currentPathGain = 0;
        if(root == null) return 0;

        if(root.left != null) leftGain = Math.Max(0, CurrentPathGain(root.left));
        if(root.right != null) rightGain = Math.Max(0, CurrentPathGain(root.right));
        currentPathGain = root.val + Math.Max(leftGain, rightGain);

        maxPathSum = Math.Max(maxPathSum, leftGain + root.val + rightGain);
        return currentPathGain;
    }
}
