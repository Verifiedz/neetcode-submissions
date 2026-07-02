public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> dict = new Dictionary<int, int>();
        int compliment = 0;
        for (int i = 0; i<nums.Length;i++){ //one pass
            compliment = target - nums[i];
            if(!dict.ContainsKey(compliment)){
                dict.Add(nums[i],i);
            }
            else{
                return new int[] {dict[compliment], i};
            }
        }
       
     return null;
    }
}


// dict: 5,0
// dict: 5,1 

// 10 - 5 = 5
//