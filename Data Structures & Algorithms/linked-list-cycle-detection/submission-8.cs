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

 solve this question in 0(1) time without using an extra data structure

 slow and fast pointer for linked list
 floyd cycle finding algorithm

 */

public class Solution {
    public bool HasCycle(ListNode head) {

        var fast = head;
        var slow = head;
        
        while(fast != null && slow != null && fast.next != null){

            slow = slow.next;
            fast  = fast.next.next;
            if(fast == slow) return true;
        }
        return false;
    }
}
