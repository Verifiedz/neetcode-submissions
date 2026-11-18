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

    solving this question in the BFS approach as well.


        we use a queue for BFS approach
 */

public class Solution {
    public int GoodNodes(TreeNode root) {
        int max = root.val;
        int totalCount = 0;
       Queue<(TreeNode,int)> queue = new Queue<(TreeNode,int)>(); 
        if(root != null) queue.Enqueue((root,max));
       while(queue.Count != 0){
            (TreeNode currentNode,int max) value = queue.Dequeue();
            if(value.currentNode != null && value.currentNode.val >= value.max){
                value.max = value.currentNode.val;
               totalCount+=1; 
            }
            if(value.currentNode.left != null) queue.Enqueue((value.currentNode.left, value.max));
            if(value.currentNode.right != null) queue.Enqueue((value.currentNode.right,value.max));
       } 
       return totalCount;
    }
}
