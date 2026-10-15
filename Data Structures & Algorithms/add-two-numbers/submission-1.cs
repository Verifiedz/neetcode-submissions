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

 given two linkedlists non negative #

 stored in reverse order

    each node contains a single digit
    no two numbers contain leading 0s except 0

    we can do a two pass approach:

        attempt 1:
            we need to iterate through the nodes and add and store t
            the result in a new linkedlist, after we need to iterate to wire the linked list
    lets store the result in a list

    List<ListNode> list = new List<ListNode>();
     while(l1 != null && l2 && != null){

        var result = l1.val + l2.val;
        if(res > 9){
        
        }
        list.Add(new ListNode(result));
     }

        for(int i = 0; i <= list.Count - 1; i++){

            list[i].next  = list[i+1];
        }
        return list[0];
    }


 */

public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
       List<ListNode> list  = new List<ListNode>();
        int carry = 0;
        int val1 = 0;
        int val2 = 0;
       while ( (l1 != null || l2 != null) || carry > 0){

        val1 = (l1 != null) ? val1 = l1.val : val1 = 0;
        val2 = (l2 != null) ? val2 = l2.val : val2 = 0;
         var res = val1 + val2 + carry;
         if(res <=9){
            list.Add(new ListNode(res));
            carry = 0;
         } 
         else {
            list.Add( new ListNode(res % 10));// 18 - >  8
             carry = res / 10; // - > 1
         }   
         if(l1 != null) l1 = l1.next;
         if(l2 != null) l2 = l2.next;
       }
     
        for(int i = 0; i < list.Count; i++){
            if(i + 1 == list.Count) continue;
            list[i].next = list[i+1];
       } 

       return list[0];
    }
}
