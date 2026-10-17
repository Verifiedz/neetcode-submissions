/*
    we need to design an LRU cache
    were each entry in  the cache gets removed
    based on how recently it was used

        for this we need to store pairs of int to track
        the items that go into the LRU cache and will fill up 

        till it reaches the capacity limit. 

        to remove the least used we need to keep track 
        of the cache using a linked list
        and the linked list at the start is removed 

        first we create the node object
        then create the dict<int, Node> 

        we will have two passes one to create the keys 

        second to wire the keys 


my advice dont look at this question as an iteration that you need to populate or connect
the population only happens when you add nodes all it needs is ways to operate its endpoints


in this question Head and tail are used as anchor nodes that represetn
the wall of the linked list 
*/
    public class Node{
       public int val;
       public int key;
       public Node next;
       public Node prev;
        public Node(int _val, int _key){
            val = _val;
            key = _key;
        }

    }
 
public class LRUCache {
   Dictionary<int, Node> dict = new Dictionary<int, Node>();
    int cap = 0;
    Node head = new Node(0,0);
    Node tail = new Node (0,0);
    
    public LRUCache(int capacity) {
        // create the cache line linkedlist 
        cap = capacity;
        head.next = tail;
        tail.prev = head; 
    }
    
    public int Get(int key){
        int res = -1;
        if(dict.TryGetValue(key, out Node node)){
            res = node.val;
            node.prev.next = node.next;
            node.next.prev = node.prev;    
            AddtoFront(node);
        }
        return res;
    }
    
    public void Put(int key, int value) {
        
        if(!dict.ContainsKey(key)){
            dict.Add(key, new Node(value, key));
        }
        else{
            dict[key].val = value;
            dict[key].prev.next = dict[key].next;
            dict[key].next.prev = dict[key].prev;
        }
        if(dict.Count > cap){
            RemoveLRUNode();
        }
        AddtoFront(dict[key]);// move node to the front
    }
    public void AddtoFront(Node node){
        node.next = head.next;
        node.prev = head;
        node.next.prev = node;
        head.next = node;
    }
    public void RemoveLRUNode(){// the key field is used to remove it from the dict
        Node oldest = tail.prev;
        oldest.prev.next = tail;
        tail.prev = oldest.prev;
        dict.Remove(oldest.key);
    }

}
