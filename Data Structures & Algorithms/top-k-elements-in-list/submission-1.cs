public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        //iterate nums and record the count of each number
        //create the hashmap dictionary

        Dictionary<int,int> freq = new Dictionary<int,int>();
        PriorityQueue<int,int> queue = new PriorityQueue<int,int>();
        List<int> res = new List<int>();
        foreach(int num in nums){
            
            if(!freq.ContainsKey(num)){
                freq.Add(num,1);
            }
            else{
                freq[num]++;
            }
            
        }

        foreach(var kvp in freq){
            queue.Enqueue(kvp.Key,-kvp.Value);   
        }

        while (k > 0){
            res.Add(queue.Dequeue());   
            k--; 
        }

        return res.ToArray();
    }
}
