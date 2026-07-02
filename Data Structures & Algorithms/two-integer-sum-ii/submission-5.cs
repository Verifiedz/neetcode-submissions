public class Solution {

    /* returing indices that must add up to target provided
     index1 must be less than index 2
     we do two pointer approach and compare the numbers
     left and a right in which we increment and decrement

       numbers  = [1,2,3,4] target == 3

        loop and iterate  left < right 
        check if left != right && 
         if(LV + RV != target && left value < right value ){
            left++;
         } 
         if(LV + RV != target && left value < right value){
            right--;
         }
         else{
            return new int[] {left value, right value};
         }
         
        outer else 

        return new int[0];
         
    */
    public int[] TwoSum(int[] numbers, int target) {

        int left = 0;
        int right = numbers.Length -1;

        while(left < right){          
                int sum = numbers[left] + numbers[right];
                if(sum <target){
                    left++;
                }
                else if(sum > target){
                    right--;
                }else{
                    return new int[] {left+1, right+1};
                }                         
                }             
                return new int [0];
            
        }
        // 1 2 3 4 t= 3
        // L 1 2 3 4
        // R 4
    }

