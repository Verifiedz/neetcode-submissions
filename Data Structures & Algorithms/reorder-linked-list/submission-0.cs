/*
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 *    given a singly-list need to ReorderList
 *    the order is going to 
 *    be the start of the list and increasing 
 *    and the other list is going to be going down the list
 *
 *    create two one that will contain the normal order 
 *    -> the second order is going to be decreasing so we reverse the linkedlist
 *
 *    after we have our two lists we are to merge two lists toegerh
 *
 *
 *    ListNode dummy = new ListNode()
 *    ListNode rev = null;
 *
 *    the appr (combination of iterative + recursive) 
 *
 *    since this is a void method we arent returning a list 
 *
 *    and must modify the give head in its tracks
 *    so we dont need a dummy node since we are not returning a new list
 *    since the final list is going to be the start of the list and then the start o the end of the lost
 *
 *    we need to split the list in half 
 *
 *    we split an array before into left and right
 *    normally when we split an array it is a lot easier since we can use the length
 *    and mathematically know the half of the lenght the index and access the middle point 
 *    so finding the half becomes O(1) access 18:44
 *
 *    cant do the same with the linked list
 *
 *    intead of iterationg we can still use the fast and slow pointer approach we learned earlier
 *
 *    to figure out the exact middle 
 *
 *    since the fast pointer would be exactly double the slow when the fast pointer reaches the end of hte 
 *    linked list it would be exactly double of the slow, that would now remain(in the middle)
 *
 */
public class Solution {
    public void ReorderList(ListNode head) {
      
     // we need to divide the current head into two lists that will represent the 
     // two halfs
     ListNode prev = null;
     ListNode temp = null;
     ListNode fast = head;
     ListNode listRev = null;
     ListNode slow  = head;
     var curr = head;
//split
//example head = [1,2,3,4,5]
//slow  = 3
//fast = 5
//cutNode = 5
//listrev = [5,4,3,2,1]
//curr = [1,2,3,4,5]
//[1,5,2,4]
      while(fast != null && fast.next != null){
         
        fast = fast.next.next;
        slow = slow.next;
      }

      // first List is going to start from head and stop at the cut of point CutNode
      listRev = Reverse(slow.next, prev,temp);

      slow.next = null;

      while(curr != null && listRev != null  && curr.next != null){
       temp = curr.next;
        curr.next = listRev; 
        listRev = listRev.next;
        curr = curr.next; //2 -> 8 -> 4
        curr.next = temp;
        curr = curr.next;
      }
    }

    public ListNode Reverse(ListNode curr, ListNode prev, ListNode temp){

      if(curr != null){
        temp = curr.next;
        curr.next  = prev;
        prev = curr; 
        curr = temp;

        return Reverse(curr,prev, temp);
      }

      return prev;
    }
}
