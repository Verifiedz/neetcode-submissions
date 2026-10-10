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

important note for us to remember
    linked list are stored as objects in memory
    if i assign it as new object i would essentially reference 
    the same object in the heap.

because of this understanding for me to do this question properly

I need a way to copy the information of the object and store it somewhere where it can be accessed with ease. Now with linkedlist we can iterate easily since going down the pointer latter since there changed is easy. But we need to store the object details in memory for us to access later and have each object have at least there vals in the linked list order correct, 

we can iterate a seperate time and have the pointers organized including the random pointer we must also account for the null case that could happen before we assign anything 

approach 1: is to use dictionary: I need to be careful how to use a dictionary
especially how we are assigning the pointers, for both random and next

lets focus on how the dictionary is structured, we should have the new object that we want to create the pointers for and we should havev the key be the original linked list object.


*/

public class Solution {
    public Node copyRandomList(Node head) {

        //empty list case
        if(head == null) return null;
        Node curr = head;
        Node dummy = head;
        Dictionary<Node, Node> dict = new Dictionary<Node, Node>();

        // we need to store and create objs in the dict
        // to iterate through the list twice we need two pointers to be at the start of the lsit 
        // in this context we can use a curr and head that will start and reference the same node.
        // this is a two pass solution since we iterate twice over the same data set
        while(curr != null){
            dict[curr] = new Node(curr.val); // look at the obj params
            curr = curr.next;
        }
        // the above creates the base dict with all the obj inside it 
        // we need to deal with the wiring portion of the new list
        while( head != null){
            if(head.next != null){
                dict[head].next = dict[head.next];
            }
            if(head.random != null){
                dict[head].random = dict[head.random];
            }
            head = head.next;
        }

        // the final return is a node obj
       //return dict.Values.FirstOrDefault(); cant do this since dictionarys are unordered

       return dict[dummy];
        
    }
}
