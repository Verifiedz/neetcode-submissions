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

    need to return the kth indexed value from the tree

    its a BST since left < node.val and right > node.val

    left and right sub trees are also binary trees

    assuming all trees are BST no validation check

    the kth smallest means to iterate through the binary search tree 

    intill we made to the value next in line that is the kth

    for this having a Queue would make the most sense to do a BFS approach
    add values for traversal

    as we traverse whenever we have reached a kth traversal we know that is the vlaue that we are looking for

    for that we need to go in order of valus since we know that this is a BST

    the values on the left are oging to be < and on right > so 
    we need to process in the order of left -> root -> right 

    Global int travel = 0;

    if(root == null) return 0;

    k is the count we start with

     travel += KthSmallest(root.left, k);
    travel  += KthSmallest(root,k)
     travel += KthSmallest(root.right, k);
    if(travel == k) return root.val;
 * }
 */
// t = 1 2 3 4
public class Solution {
    int travel = 0;
    int ans = 0;
    public int KthSmallest(TreeNode root, int k) {

       if(root == null) return 0;
       if(root.left != null) _= KthSmallest(root.left, k); 
       travel++;
       if(travel == k) ans = root.val; 
       if(root.right != null) _=  KthSmallest(root.right, k);

       return ans;
    }
}
