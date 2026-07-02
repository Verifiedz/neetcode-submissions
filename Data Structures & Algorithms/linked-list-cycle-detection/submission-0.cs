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
 */
/*
 return true if there is a cycle in the linked list

  1 2 2 3 4 
*/

public class Solution {
    public bool HasCycle(ListNode head) {

     ListNode current = head;
     HashSet<ListNode> hashset = new HashSet<ListNode>();

     while (current != null){
        if(hashset.Contains(current)){
            return true;
        }
        hashset.Add(current);
        current = current.next;
     }
    return false;
    }
}
