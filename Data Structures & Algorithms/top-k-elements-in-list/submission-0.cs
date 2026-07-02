public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        Dictionary<int, int> numsCount = new Dictionary<int, int>();
        for(int i = 0;i<nums.Length;i++){
          numsCount[nums[i]] = numsCount.GetValueOrDefault(nums[i],0)+1;
        }
       PriorityQueue<int, int> heap = new PriorityQueue<int, int>();
       foreach(var entry in numsCount){
        heap.Enqueue(entry.Key, entry.Value);
        if(heap.Count > k){
            heap.Dequeue();
        }
       }
       var result = new int[k];
       for(int j = 0;j<k;j++){
        result[j] = heap.Dequeue();
       }
       return result;
    }
}
/* we set dictionary int and int

Dictionary<int, int> numCount = new Dictionary<int, int>();

// we should populate the dictionary

//for(int i = 0;i< nums.Length; i++){

    if (ContainsKey[nums[i]]){
    nums[i].Value +=1; 
    if(nums[i].Value >1){
    k++;
    }
    }


    numCount[nums[i]] = numCount.GetValueOrDefault(nums[i],0)+1;
}

for( )

we check to see if ContainsKey(nums[i])

if does not exist we add key and value to dictionary at 1 

else if it does 

if Key does exist we increment the value 

if (ContainsKey[nums[i]]){
    nums[i].Value +=1; 
}

if(nums[i].Value >1){
    k++;
}*/