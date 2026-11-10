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

    given BT we need to invert the tree

    so the larger numbers are on the left instead of the right

    we need to traverse the tree and change the pointer of the node 
    to the other one and move on 

    lets look at the smaller example: 
        3 2 1  to 3 1 2 

    the approach
        we need to do DFS go down to the bottom once we hit the bottom
        switch to the next node once the node is null

        then have this recursivly call itself

        at each node we compare the left and right if the right is large
        we swap their positions
        The bubbling up the tree is taken care of by the call stack

        TreeNode temp;
        if(root == null){
            return null;
        }
        temp = root.left;
        root.left = root.right;
        root.right = temp;

        InvertTree(root.left);
        InvertTree(root.right);

        return root;
 
 */

public class Solution {
    public TreeNode InvertTree(TreeNode root) {
        TreeNode temp;
        if(root == null){
            return null;
        }
        temp = root.left;
        root.left = root.right;
        root.right = temp;

        InvertTree(root.left);
        InvertTree(root.right);
        
        return root;
    }
}
