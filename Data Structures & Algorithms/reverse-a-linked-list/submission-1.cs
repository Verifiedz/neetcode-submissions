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
 
public class Solution {
    /*
    singly linked list

    need to reverse the linked list

    head = 0 -> 1 -> 2 -> 3

    3 2 1 0

    iterative approach
    next nodes
    we create  a temperary linked list object 

    assign the head to point 

    to point to the temporary head which will point to 
    to the prev



    */
    public ListNode ReverseList(ListNode head) {
        
        ListNode curr = head;
        ListNode prev = null;
        ListNode temp = null;

       while(curr != null){
         temp = curr.next;
         curr.next = prev;
         prev = curr;
            curr = temp;
       }  

    return prev;
    }
}
