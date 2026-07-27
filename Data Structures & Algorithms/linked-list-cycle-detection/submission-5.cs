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
    public bool HasCycle(ListNode head) {
        
        var curr = head;
        HashSet<ListNode> set = new HashSet<ListNode>();

        while(curr != null){
            if(set.Contains(curr.next)){
                return true;
            }
            set.Add(curr);
            curr = curr.next;
        }
       return false;
    }
}
    

