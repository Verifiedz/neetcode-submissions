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

    given two arrays preorder and inorder

    preorder is the preorder traveral of BT

    Rebuild the binary Tree from the pre order and in order traversals

    preorder -> root - left - right
    inorder - > left - root - right 


    only attach when we are not given a null

    increment preorder each call with an index

    then split based on the current root for recursive left and right calls
    for each attachment

    solution 1: 
    int preorderIndex = 0;
    public TreeNode BuildTree(int[] preorder, int[] inorder) {

        int left = 0;
        int right = inorder.Length - 1;
        return Build(inorder, left, right);   
    }

    public TreeNode Build(int[] inorder, int left, int right){
       int mid = 0; 
       if(left > right) return null;
       for(int i = left; i <= right; i++){
        if(inorder[i] == preorder[preorderIndex]){
        mid = i;
        break;
        }
       }
       TreeNode root = new TreeNode(preorder[preorderIndex]); 
       preorderIndex++;

       root.left = Build(inorder, left, mid - 1);
       root.right = Build(inorder, mid + 1, right);

       return root;
    }


    
 * }
 */

public class Solution {

    int preorderIndex = 0;
   public TreeNode BuildTree(int[] preorder, int[] inorder) {
    int left = 0;
    int right = inorder.Length  - 1;
        return Build(preorder,inorder, left , right);    
    }

    public TreeNode Build(int[] preorder, int[] inorder, int left, int right){
        int mid = 0;
        if(left > right) return null;
        for(int i = left; i <= right; i++){
            if(inorder[i] == preorder[preorderIndex]){
                mid = i;
                break;
            }
        }

        TreeNode root = new TreeNode(preorder[preorderIndex]);
        preorderIndex++;
        root.left = Build(preorder,inorder, left , mid - 1);
        root.right = Build(preorder,inorder, mid + 1 , right);

        return root;
    }
}
