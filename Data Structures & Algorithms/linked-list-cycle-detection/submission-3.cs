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

 iterate through the linked list and check to see if it points back 
 at a prev linked list

 create hashset of ListNode store each Node as it iterates 
 if next node is a list node seen before then there is a cycle 

 */

public class Solution {
     public bool HasCycle(ListNode head) {

        var curr = head;
        HashSet<ListNode> set = new HashSet<ListNode>();

        if(head == null) return false;
        while(curr.next != null){
            if(!set.Contains(curr.next)){
                set.Add(curr);
            }
            else{
                return true;
            }
            curr = curr.next;
        }
       return false;
    }
}
