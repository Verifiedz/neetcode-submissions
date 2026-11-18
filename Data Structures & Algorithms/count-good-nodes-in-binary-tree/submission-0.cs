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

        node x is considered good if the path from the root of the tree to a x node
        contains no nodes with value greater than the value o node x 

        find the number of good nodes given root 

        we will do DFS approach and go down the nodes
        DFS traversal we then count the valid Nodes by checking both the parent
        and child nodes if they exist whether they follow the rules or not
        parent must be smaller and the child nodes should both be larger numbers
        only then will the count be incremented

        check null nodes
        number has to be greater or less depending on parent or child no other case

        the count will mater if the node is valid
        approach
        TreeNode prev = null;
        int totalCount = 0;
        if(root == null){
            return 0;
        }
         
        int count  = IsGoodNode(root,prev);
        totalCount += count;
        prev = root;
        if(root.left != null) _= GoodNodes(root.left);

        if(root.right != null) _= GoodNodes(root.right);

        
        public int IsGoodNode(TreeNode node, TreeNode prev){
            if(node == null || prev == null) return 0;
            if((node.val > prev.val) && (node.val < node.left.val) && (node.val < node.right.val){

                return 1;
            }

            return 0;
        }
        
 */

public class Solution {
    public int GoodNodes(TreeNode root) {
        int maxSoFar = root.val;
        return IsGoodNode(root,maxSoFar);
    }
    public int IsGoodNode(TreeNode node, int maxSoFar){
        int totalCount = 0;
        if(node == null) return 0;
        if((node.val >= maxSoFar)){
            
            maxSoFar = node.val;
            totalCount += 1;
        }
        if(node.left != null) totalCount += IsGoodNode(node.left, maxSoFar);
        if(node.right != null) totalCount += IsGoodNode(node.right, maxSoFar);
    
         return totalCount;
    }
}
