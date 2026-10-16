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

 planning to create a second solution that will rely on a one pass
 approach instead of two pass and the use of a list that we did 
 this is more modular of a app

    we need to check when the l1 and l2 reach the end

    we need to keep in mind the carry if it passes 9 two digits
    
    l1 and l2 at some point may not contain a value but the other might 
    
 */

public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode dummy = new ListNode(0);
        ListNode curr = dummy;
        var carry = 0;
        var val1 = 0;
        var val2 = 0;
        while(l1 != null || l2 != null || carry > 0){
            
            val1 = (l1 != null) ? l1.val : 0;
            val2 = (l2 != null) ? l2.val : 0;
            var res  = val1 + val2 + carry;
            if(res <= 9){

                curr.next = new ListNode(res);
                carry = 0;
            }
            else { 
                curr.next = new ListNode(res % 10);
                carry = res / 10;
            }
            if(l1 != null) l1 = l1.next;
            if(l2 != null) l2 = l2.next;

            curr = curr.next;
        }
        return dummy.next;
    }
}
