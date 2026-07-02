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
 // take the list and merge them combine the list and sort it 
 // we can sort the list by just comparing the items in the list
//

 //
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode dummy = new ListNode(-1);
        ListNode current = dummy;


        while(list1 != null && list2 != null){

            if(list1.val < list2.val){
                current.next = list1;
                list1 = list1.next;               
            }
            else {
                current.next = list2;
                list2 = list2.next;
            }
            current = current.next;
        }
        if(list1 !=null) current.next = list1;
        else current.next = list2;
        return dummy.next;
    }
}