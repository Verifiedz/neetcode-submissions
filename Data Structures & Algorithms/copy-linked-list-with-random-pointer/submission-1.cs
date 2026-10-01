/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}

    linked list approaches: Fast slow, window or two pointers at diff points
                            reverse and recursion 
    head n 
    - linked list has additional random pointer
        -point or null
    
    create cp
        include: val, next, and random
    
    pointers in the list should not be pointing to og list

    saving?
        use a dictionary and store node, randomindex
            to save the old linked list and then add it to the new one  
    ex: [val, random_index] 

    problem i see now with this approach after coding is if i store the linkedList
    into a hashset like this the object still references the other original list
        meaning we need to copy the values and create a new linked list value 
        and store that in the dictionary and then create the linked list values as we go 

        problem is we cant then store 3 values in one dictionary or hashet
        and then create these after 

        im assuming the old list doesnt dissappear we just need a cpy 

        how do i store the old context value before creating new linked list object

    attempt 1:

        ListNode copy = new ListNode(0);
        ListNode curr = head;
        HashSet<ListNode> set = new HashSet<ListNode>();

        while(curr != null){

            if(!set.Contains(curr)){
                set.Add(curr);
            }
        } 

    atempt 2:
        we just need to store the copy of the object linkedList and 
        we can add its pointers later

        Dictionary<ListNode,ListNode> dict = new Dictionary<ListNode,ListNode>();
        ListNode curr = head; 
        while (curr != null){ //creating copys of the listNode

            dict[curr] = curr;
        }
        //do the wiring after

        ListNode copy = new ListNode(0);

        foreach(var node in dict){
            //how to reference the next ListNode
            there are 2 possibilities that im thinkin of 
            converting the dictionary to a list or storing the previous dictionary entry seperatly
            using a keyValuePair obj only issue is that previus would be overwritten as we iterate
            nad the other of which the pointers need to reference are not linear
            so the approach and converting to a list and indexing is making sense

            //or since these are linkedList they reference the other automatically i can keep iterating next and then wire that way 
            to a new linked list.
            node.Value.next = 
            node.Value.random = 
        }

       Attempt 3: 
       Dictionary<Node, Node> dict = new Dictionary<Node, Node>();
       Node curr = head;

       while( curr != null){

            dict[curr] = new Node(curr.val);

            curr = curr.next;
       } 

       while(head != null){// we need to attach the wiring of the nodes pointers

        dict[head].next =  dict[head.next];
        dict[head].random = dict[head.random];

        head = head.next;
       }
       

    }
*/

public class Solution {
    public Node copyRandomList(Node head) {
        Dictionary<Node, Node> dict = new Dictionary<Node, Node>();
        Node curr = head;
        Node copy = new Node(0);

        while( curr != null){

            dict[curr] = new Node(curr.val);

            curr = curr.next;
        }

        while( head != null){

            if(head.next !=null){
                dict[head].next = dict[head.next];
            }  
            if(head.random != null){
                dict[head].random = dict[head.random];// would have to see if the null case will cause an issue
            }
            head = head.next;
        }

        copy = dict.Values.FirstOrDefault();// return in a list format of val, random index
        return copy; 
        
    }
}
