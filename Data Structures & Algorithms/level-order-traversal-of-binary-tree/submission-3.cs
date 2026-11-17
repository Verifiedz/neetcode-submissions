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
        we need to output each level of the tree its children
        all in one sublist and then the next layer would be considered in the sublist
        meaning we need to traverse the nodes at each level and not each depth
        instead of DFS we are going to do BFS

        to do this we dont need to have a recursive call stack approach
        that allows us to go deeper into the tree till we hit a null node

        rather to get through each level we are going to use a QUEUE and a

        while loop iterative approach to go through each of the nodes depending on a 
        condition

        approach 1: 
            start at the root add it into the queue

            1 get added then we remove it since that would be the first list

            then we add each of the children and keep count of the elements 
            of each queue so we know when to go down a level
        
            so qeueu the count should be at 1 and then the while loop will go for 2 elemets
            add it the the queue

            example [1,2,3,4,5,6,7]

            add 1 to queue then dequeue while queue not empty add to list
            then increase the count at the end for the next st of values
            Queue<TreeNode> queue = new Queue<TreeNode>();
            var res = new List<List<int>(); 
            int levelCount = 1;
        
          if(levelCount == 1)  queue.Enqueue(root);
           while(queue.Count != 0){
                    res.Add(new List<int>{queue.Dequeue().val})
                }
            while(queue.Count < levelCount){
               if(root.left != null) queue.Enqueue(root.left);
               if(root.right != null) queue.Enqueue(root.right);
            }
                 levelCount *=levelCount + 1;
            return res;

            approach 2

            Queue<TreeNode> queue = new Queue<TreeNode>();
            int levelCount = 0;
            List<List<int> res = new List<List<int>();
            var temp;
            first while loop is to dequeue the elements as long as the queue is not empty
            then we enqueue the elements exactly the amount of time as levelCount
            have a temperary array that will store values and only add that to the result array
            after the inner for loop is done

            queue.Enqueue(root);
            while(queue.Count != 0){
             temp = new List<int>();
                 
             levelCount = queue.Count;
                temp.Add(queue.Dequeue().val);

                for(int i = 0; i <= LevelCount;i++){
                    queue.Enqueue(root.left);
                    queue.Enqueue(root.right);
                }
                res.Add(temp);
            }
            return res;
        } 
 */
 
public class Solution {
    public List<List<int>> LevelOrder(TreeNode root) {
       Queue<TreeNode> queue = new Queue<TreeNode>(); 
       int levelCount = 0;
       var res = new List<List<int>>();
       var temp = new List<int>();
//[1,2,3,4,5,6,7] [1,2] [[1]]
       if(root != null) queue.Enqueue(root);//so that the queue is not empty
       while(queue.Count != 0){
        temp = new List<int>();
        levelCount = queue.Count;
            for(int i = 0; i < levelCount;i++){       
                TreeNode currentNode = queue.Dequeue();  
                temp.Add(currentNode.val);
                if(currentNode.left != null) queue.Enqueue(currentNode.left); 
                if(currentNode.right != null) queue.Enqueue(currentNode.right);
            }
            res.Add(temp);
        }
        return res;
    }
}
