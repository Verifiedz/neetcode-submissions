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
 given two lists merge into sorted list

 list1
 list2 

    take the l1 head

    iterate through the linked list 
    if l1.val < l2.val

        destroy the old pointer and point to the second listnode


        while(curr.next != null){

            if(l1.val <= l2.val){
                temp = l1.next;
                l1.next = l2;
                l2 = l1;    
            }
            else{
                temp = l2.next;
                l2.next = l1;
                l1 = l2;
            }
            curr = temp;
        }

 */
 
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode temp = new ListNode();
        ListNode curr = temp;
        while(list1 != null && list2 != null){
            if(list1.val >= list2.val){
                curr.next = list2;
                list2 = list2.next;
            }
            else{
                curr.next = list1;
                list1 = list1.next;
            }
            curr = curr.next;
       }
       if(list1 != null){
        curr.next = list1;
       }
       else{
        curr.next = list2;
       }
       return temp.next;
    }
}