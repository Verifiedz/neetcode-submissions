public class Solution {
    public int LongestConsecutive(int[] nums) {
        int count = 1;   
        int maxCount = 1;
         if(nums.Length == 0 || nums == null){ //gaurd rail
                return 0;
            }
        Array.Sort(nums);
        for(int i = 1;i<nums.Length;i++){
            
           
             if((nums[i] == nums[i-1] + 1)){
                count++;
            }
            else if (nums[i] == nums[i-1]){
                continue;
            }
            else{
                maxCount = Math.Max(count,maxCount);
                count = 1;
            }
            
            
        }
        return Math.Max(count,maxCount);
    }    
}


