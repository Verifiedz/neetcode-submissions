public class Solution {
    public bool hasDuplicate(int[] nums) {

        //take the array store each value in nums as a key for a dictionary
        // increment count by 1 each time a new entry matches the key
        // count will be the value 


        Dictionary<int, int> numsCount = new Dictionary<int, int>();
        int count = 0;
        for(int i = 0; i <nums.Length; i ++){
            
            if(numsCount.ContainsKey(nums[i])){
                return true;
            }
            else{
               numsCount.Add(nums[i], 1);
            }
        }
        return false; 
    }
}

