public class Solution {
    public bool hasDuplicate(int[] nums) {

        HashSet<int> dup = new HashSet<int>();

        foreach(int num in nums){
            
            if(!dup.Contains(num)){
                dup.Add(num);
            }
            else {
                return true;
            }        
        }
        return false;
    }
}