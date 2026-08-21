
// @leet end
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
 *
 * given the curret head of the list
 * need to remove the nth node from the end of the list
 * this means we need to look at the elements from the end of the list 
 * since a linked
 * list points to the next obj in order 1 -> 2-> 3-> 4->5
 * the only way normally to access nth from th end would be to reverse the linked list
 * but that would be 0(n) time since we need to iterate through the linked list once
 * and then iterate backwards, possible 0(N^2)
 *
 * instead we can have two pointer approach but apply that to a linked list
 * as it pretains to linkedlist it is called the runner technique
 *
 * we start the first pointer at a head start which will point to the kth elements
 * so in this context it would be n from there we know the left pointer 
 * is exactly n elements behind, we iterate till the right pointer reaches the end
 * after that k would be the exact element that we need to remove 
 * logically im thining of having k be one number extra so that we can change the pointer
 * to point directly to right.
 *
 *  psuedo Code:
 *
 *  ListNode right = head;
 *  ListNode left = head;
 *
 * need to forward right k # 
 * int k = n + 1;
 * while(k >= 0 && right != null){
 *  
 *  right = right.next;
 *
 * }
 *
 * while(right != null && left != null){
 *
 *  right = right.next;
 *  left = left.next;
 * }
 *
 * right should be at last elemetn
 * left should be k elements behind if n is 2 k is 3
 *
 * left.next = right;
 */
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
     
      ListNode right = head;
      ListNode dummy = new ListNode(0,head);
      ListNode left  = dummy;
      int k = n;
       
      //displace teh right pointer k elements ahead
      while(right != null && k > 0){ 
        right = right.next;
        k--;
      }
      
      //now iterate through the linkedlist untill it reaches the end
      while(right != null){
        right = right.next;
        left  = left.next;
      }

      //remove the element of 3 by removing the pointers
        left.next = left.next.next;
         

      // right: 4 left : 2    2 ->3  3 -4
     return dummy.next;  
    }
}
