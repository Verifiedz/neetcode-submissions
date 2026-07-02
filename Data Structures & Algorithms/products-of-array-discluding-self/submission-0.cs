public class Solution {
    /*

    */

    public int[] ProductExceptSelf(int[] nums) {
        var res = new int[nums.Length];
        for(int i = 0; i<nums.Length;i++){
            var product = 1;
            for(int j = 0; j<nums.Length;j++){
                if(i!=j){
                    product = product*nums[j]; 
                }
            }   
            res[i] = product;
        }
        return res;
    }
}
