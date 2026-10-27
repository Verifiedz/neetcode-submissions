public class Solution {

    /*
        solve this question in 0(log n) time 

        given nums arr

        rotation means to the left 

        we need to dtermine the min

            we will have cond comparing the number to mid point

            normally with a sorted array we can adjust the # left or right since 

            numbers on the left are smaller and numbers on the right are larger

            for this binary search we need to keep in mind of the rotation point

            so the cond we move are pointers are based on the rotation point

            so instead of having a static change of moving left and right we
            move the one that is larger up

            attempt

            var left = 0;
            var right = nums.Length;
            var mid = 0;

            // [3,4,5,6,1,2]  2 > 1  true: 

            while (left <= right){
                mid = left + (right - left)/2;

                if(nums[mid] > nums[right]){
                    left = mid +1;
                }
                else{
                    right = mid -1;
                }
               }
            }
            return nums[mid];
    */
    public int FindMin(int[] nums) {

        var left = 0;
        var right = nums.Length -1;
        var mid = 0;

        while(left < right){
            mid = left + (right - left)/2;
            if(nums[mid] > nums[right]){
                left = mid + 1;
            }
            else{
                right = mid;
            }
        }
        return nums[right];       
    }
}
