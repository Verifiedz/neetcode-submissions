public class Solution {

    // another way to solve these type of problems is by assesing the array from left
    // to right
    public int[] ProductExceptSelf(int[] nums) {

        int[] product = new int[nums.Length];

        product[0] = 1;

        // we want to check all indexes from the left side first or known as (prefix)

        for(int i = 1;i<nums.Length;i++){
            product[i] = product[i-1]*nums[i-1];    
        }        
        int suffix = 1;
        for (int i = nums.Length-1;i>=0;i--){
            product[i] *= suffix;
            suffix *=nums[i];
        }
        return product;
    }
}





