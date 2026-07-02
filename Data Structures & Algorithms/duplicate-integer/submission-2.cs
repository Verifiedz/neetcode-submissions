public class Solution {
    public bool hasDuplicate(int[] nums) {
        
        HashSet<int> hset = new HashSet<int>();

        foreach(int num in nums){
            if(hset.Contains(num)){
                return true;
            }
            else{hset.Add(num);}
        }
        return false;
    }
}