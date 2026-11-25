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
    Valid Binary Search Tree

    given root  true valid under the following cond:


    left side < root
    right > root

    the left and right are also binary search trees

    it means the left and right side individually alos have left and right smaller children compared to it nodes


    edge case considerations
        we need to see if the node is null 
        we need a way to keep track if it stays smaller or larger

        the max and min node to make sure the larger binary tree is a search

        if the node is smaller than the max we know its on the left side
        and for a node on the right it needs to be more than the minimum
        to be valid

        we need to update the min and max after each iteration

     public bool Validate(TreeNode node , int? max, int? min){
   
        if(root == null){
            return true;
        }
        
        if(node.val >= node.left.val){
            if(node.left.val > max) return false; // so it should bubble 
            max = node.val;
            Validate(node.left, max, min);
        }
        if(node.val <= node.right.val){
            if(node.right.val < min) return false;
            max = node.val;
            min = node.val;
            Validate(Node.left, max, min);
        }
        return true;
     }

        
    



 */

public class Solution {
    public bool IsValidBST(TreeNode root) {
        if(root == null) return true;
        return Validate(root, null , null);
    }

    public bool Validate(TreeNode node, int? max, int? min){
        bool left = true;
        bool right = true;
       if(node == null) return true;

       if(node.val >= max) return false;
       if(node.val <= min) return false;
       if(node.left != null)  left = Validate(node.left, node.val,min);
       if(node.right != null)  right = Validate(node.right, max, node.val);

       return left && right;
    }
}
