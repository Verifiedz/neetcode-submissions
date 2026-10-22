public class Solution {
    /*binary search solution

    arr of int sorted and asc
    and a target

    implement a search func  for target in nums

        if exists return its index, otherwise return -1 

        0(logn) tree like structure
*/
    public int Search(int[] nums, int target) {

        //first we need to create the tree to solve this question

        int left = 0;
        int right = nums.Length -1;


        while(left <= right){
         int mid = left + (right - left)/2;

         if(nums[mid] == target) return mid;

         if(nums[mid] < target){
            left  = mid + 1; 
         }

         if(nums[mid] > target){
            right = mid - 1;
         }
        }
        return -1;
    }
}
