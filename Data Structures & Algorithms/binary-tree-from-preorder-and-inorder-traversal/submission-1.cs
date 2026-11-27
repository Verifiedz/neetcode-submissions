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


    given two lists the preorder and the inorder of BT

    we need to rebuild the binary tree

    ex 1 preorder we have [1,2,3,4] and inorder we have [2,1,3,4]

    the preorder is in format of 

    root -> left -> right
    inorder-> left -> root -> right

    together we can create the bt in the correct structural form

    we can have a variable for the preorder index
    that will give use the current root

    we need to focus on one node at a time and we 
    need to take in the left and right side of the list to 

    recursivly add to that node for each node

    we need a seperate helper so that we can keep track of the ends of the
    in order list
    solution 1:

    int preorderIndex = 0;
    int left = 0;
    int right = inorder.Length - 1;




 */

public class Solution {
        int preorderIndex = 0;
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        preorderIndex = 0;
        int left = 0;
        int right = inorder.Length - 1;

        return Build(preorder,inorder,left, right);
    }

    public TreeNode Build(int[] preorder, int[] inorder, int left, int right){
        if(left > right) return null;
        TreeNode node = new TreeNode(preorder[preorderIndex]);
        preorderIndex++;
        int mid = 0;
        for(int i = left; i <= right;i++){
            if(inorder[i] == node.val){
                mid = i;
                break;
            }
        }

        node.left = Build(preorder,inorder, left, mid - 1);
        node.right = Build(preorder,inorder, mid + 1, right);

        return node;
    }
}
