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
 /*linked list \
  0 1 2 3 
  0 is head 

  0 -> 1 -> 2 -> 3 

  ListNode current = head;
  var prev = null; 
  var dummy =null;

  while(current !=null){

    dummy = current.next 
    current.next = prev;
    prev = current;

    current = dummy  
  }
  return prev;

  our head should become 3 


 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        var current = head;
        ListNode prev = null;
        ListNode dummy =null;

        while(current != null){
            dummy = current.next;
            current.next = prev;
            prev = current;

            current = dummy;
        }
        return prev;
    }
}
