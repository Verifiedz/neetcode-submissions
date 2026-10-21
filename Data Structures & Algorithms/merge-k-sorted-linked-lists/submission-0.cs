/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }

    merg k sorted linked list

    each LL is in asc

    we need one final linked list

        - create a res linked list which will be head of the final list
    
    we must iterate and check the heads of all the linked list
    in the list and attach the smallest head to the res linked list

        then we iterate the head of each linked list and then again
        we add it to the final list

            how to get each head?

            we need one pass to have each list and their linked list

                but a standard mapping cant be enough since we need 
                to also have the one with the lowest priority
            essentially using a min heap creating a tree structure

            with smallest parent will help us have the smallest of the heads 
            so that we can then merge it into our final list

        we need a pass to iterate the heads of each element

        in the list we can have a helper method 


for queue its enqueue(ele, prio)
 the queue will handle sorting in terms of min prio
in this context the lower val you use will work

since nodes have this val the smaller it is the lower in the prio 

    its going to be
    PriorityQeueue<ListNode, int> queue = new PriorityQueue<ListNode, int>(); 
        
        foreach( ListNode node in lists){
            Enqueue(node,node.val);
        }
        while(!queue.Empty){

        res.next =  new ListNode(queue.Dequeue.val);
            node = node.next; // the next node
            queue.Enqueue(node, val);
        }


        edge cases and empty LinkedList


 */

public class Solution {    
    public ListNode MergeKLists(ListNode[] lists) {
       PriorityQueue<ListNode, int> queue = new PriorityQueue<ListNode, int>();
       ListNode res = new ListNode(0);
       ListNode dummy = res;
       //we need to get the min heap set up with all the heads

       foreach(var node in lists){
           if(node != null) queue.Enqueue(node, node.val);
       } 
        //the top has all the heads in the queue, we need to go a second pass
        //to get all the nodes in order into the prio queue to get it sorted

        while(queue.Count > 0){
            // we need to remove the min
           ListNode curr = queue.Dequeue();
           if(dummy != null) dummy.next = new ListNode(curr.val);
            dummy = dummy.next;
            curr = curr.next;
            if(curr != null) queue.Enqueue(curr, curr.val);
        }
        return res.next;
    }
}
