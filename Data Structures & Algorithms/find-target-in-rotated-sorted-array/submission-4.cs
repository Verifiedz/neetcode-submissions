public class Solution {
    /*

        attempt 1:

            int l = 0, int right = nums.Length - 1;
            int mid = 0;

            while(left <= right){
                    [3,4,5,6,1,2] targ = 1  6 
                    mid = left + (right - left)/2;
                    
                    if(nums[left] < nums[mid]){
                        // we know that this point is sorted 
                        we need to check the left side
                        we need to see if it exists on this side
                        if(nums[left] <= target && target < nums[mid]){
                            right = mid;
                        }
                        else{
                            left = mid +1;
                        }
                    }
                    if(nums[right] > nums[mid]){

                        if(target <= nums[right] && target > nums[mid]){
                            left = mid +1;
                        }
                        else{
                            right = mid;
                        }
                    }
            }
            return -1; 
    */
    public int Search(int[] nums, int target) {
       int left = 0; int right = nums.Length -1;
       int mid = 0; 

       while(left <=right){
            
           mid = left + (right - left)/2;
            if(nums[mid] == target){
                return mid;
            }
            if(nums[left] <= nums[mid]){
                
                if(nums[left] <= target && target < nums[mid]){
                    right = mid;
                }
                else{
                    left = mid + 1;
                }
            }    
            else if(nums[right] >= nums[mid]){
                
                if(nums[right] >= target && target > nums[mid]){
                    left = mid + 1;
                }
                else{
                    right = mid;
                }
            }
       } 
               

       return -1;
    }
}
