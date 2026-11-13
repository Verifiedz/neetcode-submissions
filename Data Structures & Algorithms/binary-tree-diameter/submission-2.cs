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
    
    diameter of tree -> length of the tree longest path between any two nodes
    within a tree, the path does not necessarily need to pass through the root

        length of a path between two nodes in a binary tree is the #
        of edges between each node not including the node again if traveresed


    we need to find the diameter

        longest path between any two nodes no repeating nodes and not need to be root

        1 2 3 4 5 

        1 2 3 1

        longest length is 3 (all the edges that make the longest path)

        keep traversing intill you hit the end or a node that has been visted before

        DFS we can count the length as we traverse a node
        essentially the node with highest count and does not fail any of the cond:

        is there a way to disgard a branch if it fails a check?

        [1 2 3 4 5]
        HashSet<int> set = new HashSet<int>();
        int length1 = 0;
        int length2 = 0;
        if(root == null){
            return 0;
        }

        length1 = DiameterofBinaryTree(root.left);
        length2 = DiameterOfBinaryTree(root.right);

        if(!set.Contains(root.val)){
            
            if(length1 > length2) return length1 + 1;
            if(length1 < length2) return length2 + 1;
        }
        else{
            return 0;
        }

 */

public class Solution {
    int diameter = 0;
    public int DiameterOfBinaryTree(TreeNode root) {
      
        TreeTraversal(root);

        return diameter; 

    }

    public int TreeTraversal(TreeNode root){
          if(root == null){
            return 0;
        }
       int length1 = TreeTraversal(root.left);
       int length2 = TreeTraversal(root.right);
       
       diameter = Math.Max(diameter, length1 + length2);

       return Math.Max(length1,length2) + 1;
    }
}
