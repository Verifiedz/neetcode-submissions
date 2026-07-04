public class Solution {
    public int[] ProductExceptSelf(int[] nums) {

        /*
        given nums = [1, 2 ,4,6]
        return list of products of the all the nums[i] excluding the current nums[i]
        ideally to solve in O(N) time

        sol: 

        brute force is to iterate and use a nested loop system to iterate the i and the rest as prod
        */
        int[] res = new int[nums.Length]; 
        for(int i = 0; i < nums.Length;i++){
            int product = 1;
            for(int j = 0; j < nums.Length;j++){

                if(i!=j){
                    product = nums[j] * product;
                    
                }
            }
            res[i] = product;
        }
        return res;
    }
}
