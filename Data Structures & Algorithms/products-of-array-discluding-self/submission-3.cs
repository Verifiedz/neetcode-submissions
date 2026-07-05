public class Solution {
    public int[] ProductExceptSelf(int[] nums) {

        /*
        given nums = [1, 2 ,4,6]
        return list of products of the all the nums[i] excluding the current nums[i]
        ideally to solve in O(N) time

        sol: 

        brute force is to iterate and use a nested loop system to iterate the i and the rest as prod
        
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

        Optimal Approach:

        */
// Arrays
// try to never split an array that means you are copying Memory
    int[] prodL = new int[nums.Length];
    int[] prodR = new int[nums.Length];
    int[] res = new int[nums.Length];

    prodL[0] = 1;
    prodR[nums.Length-1] = 1;
        //First Pass Left split
        for(int i = 0; i < nums.Length ;i++){
            if(i!=0){
                prodL[i] = nums[i-1]*prodL[i-1];
            }
        }
        // 1 1 2 8 


        //Second Pass right split
       for(int i = nums.Length - 1;i >= 0;i--){
            if(i!=nums.Length -1){
                prodR[i] = nums[i+1]*prodR[i+1];
            }
       } 
       //       
       for(int i = 0; i < nums.Length;i++){

            res[i] = prodL[i]*prodR[i];
       }
       return res;
    }
}
