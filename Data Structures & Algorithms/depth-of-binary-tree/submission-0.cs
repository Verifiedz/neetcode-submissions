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
    need to return the depth

        depth: of BT is defined as the number of nodes along the longest
        path from the root node down to the furthest leef
    
    we would traverse down find the depth of a branch then
        get that count return it and compare to see if its the higher
        one
 */

public class Solution {
    public int MaxDepth(TreeNode root) {
       if(root == null){
        return 0;
       }

        int leftCount = MaxDepth(root.left);
        int  rightCount = MaxDepth(root.right);
        /*
            by keeping the variables localized each call would have 
            its own variables, if it was defined in the class they would
            overrite eachothers values
        */

        if(leftCount > rightCount){
            return  leftCount + 1;
        } 
        else{
            return rightCount + 1;
        }
    }
}

