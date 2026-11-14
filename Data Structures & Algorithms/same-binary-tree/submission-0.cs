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

    given two bts p and q return true if the trees are equivalent

    otherwise False

        equal if same structure meaning branches are the same

        and the val in the nodes are the same as well

        we iterate and compare the trees to see if they match on val

        and if they share the same left and right branches
 */

public class Solution {

    public bool IsSameTree(TreeNode p, TreeNode q) {
        if(p == null && q == null){
           return true;
        }  
        if(p == null || q == null){
            return false;
        }

        if(p.val != q.val) return false;
        bool left = IsSameTree(p.left,q.left);
        bool  right = IsSameTree(p.right,q.right);


 
        return right && left;
    }

}
