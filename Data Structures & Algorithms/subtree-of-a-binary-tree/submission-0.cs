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
    root and subroot true 
        if subroot is subtree of root
            same structure and node values as in root

        subtree of bt is a tree that consist of a node and all of its
        children are the same as the sub tree

        so we neet to iterate through till we find the first value then we 
        
        
 */

public class Solution { 
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {

            if(root == null){
                return false;
            }

            if(root.val == subRoot.val && IsSameTree(root,subRoot)) return true;


            bool left = IsSubtree(root.left, subRoot);
            bool right = IsSubtree(root.right,subRoot);
         
        return (left || right);            
    }

    public bool IsSameTree(TreeNode p, TreeNode q){

        if(p == null && q == null) return true;
        if(p == null || q == null) return false;
        if(p.val != q.val) return false;

        bool left = IsSameTree(p.left, q.left);
        bool right = IsSameTree(p.right,  q.right);

        return left && right; 
    }
}
