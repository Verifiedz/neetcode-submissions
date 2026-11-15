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
    we are given two nodes from the tree in isolation
        return LCA
        both p and q are the lowest decendance, both have to be lower decendance
        if one is decendant of the other that is fine 

        we just need to see if a number is
        we need to run a DFS search and see if both nodes are greater
        are on the left and right side of a particular node if no
        and one of the is part of each other then it is a LCA with one of them being 
        that case

        in example 1 if we iterate and check each node 1 is smaller than both
        so it would be on the left side move on 

        then 2 same thing, 3, would be fine in comparison of its self but even with 8 being greater 8 is not the child of of 3 both need to be children

        approach:

        wether root is larger than one of the values and smaller then the other

        else we check if one is larger and is children of current root. or smaller
        then this is a self identifying case


        approach:

        if(root == null){
            return null;
        }

        _= LowestCommonAncestor(root.left,p,q);
        _= LowestCommonAncestor(root.right,p,q);
        if(root.val > p.val && IsChild(root,p) && (root.val < q.val && IsChild(root,q))){
            return root; 
        }
        if(root.val == p.val && IsChild(root,p)){
            return root;
        }
        if(root.val == q.val && IsChild(root,q)){
            return root;
        }


        public bool IsChild(TreeNode n, TreeNode s){
            if(n.left == s || n.right == s) return true;
            return false;
        }

        NOTE : invalid assumption the ancestor does not need to be direct children

        since its a binary search we need to narrow the search down and see
        if they share a common ancestor
 */

public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {

        if(root == null){
            return null;
        }


        if(q.val < root.val && root.val >  p.val )  return LowestCommonAncestor(root.left, p , q);  
        if(q.val >root.val && root.val < p.val)  return LowestCommonAncestor(root.right, p , q); 

        return root;
            
    }
   
}
