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

    details:
        singly head
        and pos integer k

        reverse every k nodes till less than k left
        and attach the remaining nodes
        allowed to modify the pointer not the vals

        steps we need

        iterate through the linked list till we reach k 

        reverse the current nodes then iterate another k reverse

        posibilities:
            split the list at k then re attach
            have a sliding window of size k then:
                reverse then move the window 
                keep track the first node in the window fixed
                so we can reference it later

        edge case: Null node case
        var curr = head;
        var res = new ListNode(0); 
        var count = 0; 
         while(count < k){
           var temp = null;
           var prev = null;
           temp = curr.next;
           curr.next = prev;
           prev = curr;
           curr  = temp;
           count++;
         }
         res.next = prev;

         //problem we did not sever the pointer

         // 

         attempt 2:

            we set up a sliding window of k
            keep track of the first node

                we initialize pointers for the windows
                increment the right pointer till we reach k
                then we do the reversal, before we move the right pointer
                from the next set of # we have our left node point to right.next
                then remove the pointer. after wer move the window by k



            so set up step to create window.

            then iteration Reversal step, we can use recursion

            then moving the sliding window and checking to see if next valid window or not 



        Solution:

            ListNode left = head;
            List Node right = head;
            var count = 0; 
            for(int i= 0; i < k;i++){
                right = right.next;
            }

                ListNode temp = null;
                ListNode prev = null;
                ListNode Curr = left;

            while(count != k){
                right = right.next;
            }
        
        going to attempt it directly
 */









public class Solution {
    public ListNode ReverseKGroup(ListNode head, int k) {
       ListNode curr = head;
       ListNode temp = null;
       ListNode prev = null;
       ListNode left = head;
       ListNode right = head;;
       ListNode dummy = new ListNode(0, head);
       
       ListNode groupPrev = dummy;
       //outer while loop to iterate till the end of the linked list

        while(curr != null){
            temp = null;
            prev = null;
            //reset the right pointer to next k 
           for(int i = 0; i < k;i++){
                if(right == null ){
                    return dummy.next;
                }
                right = right.next;
           } 

           while(curr != right){
               temp = curr.next;
               curr.next = prev;
               prev = curr;
               curr = temp; 
           }
           left.next = curr;
           groupPrev.next = prev;
           groupPrev = left;
           left = curr;
        } 
        return dummy.next;
    }
}
