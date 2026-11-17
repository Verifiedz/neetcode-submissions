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

        given root we only want values we an see from the rightside 

        this could be left or right children the way we do we need to first 

        [1,2,3,null,4,null,5] the null represent children branches that dont exist

        cond: if it is the root node it is automatically added and considered
        cond: we need to check for the starting null case
        cond: we need to check each level and make sure that there are no nodes after on each level
        if there is another node to be added at each level that final node is the node on the 
            right, so when we enqueue a node left and right if both get added the last node to leave the 
            queue would be right most and to be added into our final list.
            if only one gets added cause the is null then for taht level what ever is last would be added

            lets look at an example

            root = [1,2,3,null,4,null,5]

            we check if root is null if not we add the 
             then we dequeu one add it to the list since it is the only one on its level
            we can then enqueu the next set of values
            [4]  then we update the count and dequeu based on that 2 and 3 the last element will be 
            add to the list again add last number so only 4 would be added in teh queue


            approach 1:

                Queue<TreeNode> queue = new Queue<TreeNode>();
                var res = new List<int>();
                int levelCount = 0;

                if(root != null) queue.Enqueue(root);

                while(queue.Count != 0){
                    levelCount = queue.Count;
                    for(int i = 0; i < levelCount; i++){
                        TreeNode currentNode = queue.Dequeue();
                        if(i = levelCount -1){
                            res.Add(currentNode.val);
                        }
                        if(currentNode.left != null) queue.Enqueue(currentNode.left);
                        if(currentNode.right != null) queue.Enqueue(currentNode.right);
                    }
                }
                return res;

 */

public class Solution {
    public List<int> RightSideView(TreeNode root) {
       Queue<TreeNode> queue = new Queue<TreeNode>();
       var res = new List<int>();
       int levelCount = 0;
       if(root != null) queue.Enqueue(root);

       while(queue.Count != 0){

        levelCount = queue.Count;

        for(int i = 0; i < levelCount; i++){
            TreeNode currentNode = queue.Dequeue();
            if(i == levelCount - 1){
                res.Add(currentNode.val);
            }
            if(currentNode.left != null) queue.Enqueue(currentNode.left);
            if(currentNode.right != null) queue.Enqueue(currentNode.right);
        }
       }
       return res; 
    }
}
