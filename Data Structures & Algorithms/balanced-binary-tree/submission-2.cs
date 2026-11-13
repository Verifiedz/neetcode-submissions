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
    
    reutrn true if heigh-balanced otherwise return false
    

    height-balanced BT defined as binary tree where the left and right

    sub trees of every node differ in height by no more than 1 


    we need to keep track of the active height

    where the height is greater only by a maximum of 1 

    and return false when our condition fails 

    no psuedo Code attempt:
 */

public class Solution {
    bool balanced = true;
    public bool IsBalanced(TreeNode root) {
        
        _=  TreeTraversal(root);

        return balanced;
    }

    public int TreeTraversal(TreeNode node){

        if(node == null){
            return 0;
        }

        int leftHeight = TreeTraversal(node.left);
        int rightHeight = TreeTraversal(node.right);
        if(Math.Abs(leftHeight - rightHeight) > 1) balanced = false;

        return Math.Max(leftHeight, rightHeight) + 1;
    }
}
