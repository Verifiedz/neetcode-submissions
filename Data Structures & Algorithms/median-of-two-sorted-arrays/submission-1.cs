public class Solution {

    /*
        given two nums1 and nums2 
        
        we need to find the mediam
        getting median if its odd we take 

        n + 1 /2 in half that would be the mid

        for even 
        n /2 + n/2 + 1/2 would the case to find the medium

        
        what are searching for 

         example => nums [1,2], nums2 = [3]
            [1,2,3]
         determine if its odd or even first

         by taking the length of the two arrays
         adding them and then checking if they are odd or even

        we need to find the exact part that is half of these 2 arrays
        so that we can find mid, the split would be the median 
        in which case we can just solve for the median value.
    int left = 0; 
    int right = nums1.Length;
    int mid = 0;
    int cutP = 0;
    
            left will be the first arr and right the second
            while(left < right){
                mid = left + (right - left)/2; 

                        //size of the left bucket 
                cutP = (nums1.Length + nums2.Length + 1)/2 - mid;
                
                if(nums1[mid -1] >= nums2[cutP]){
                    right = mid -1;
                }
                else if(nums2[cutP - 1] >= nums1[mid]){
                    left = mid + 1;
                }
                else if(nums1[mid -1] <= nums2[cutP] && num2[cutP -1] <= nums1[mid1]){
                }
            } 

   */     

   /*
    attemp1: [1,2] [3]
             [1,3] [2,4] 
   */
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
       if(nums1.Length > nums2.Length){
            return FindMedianSortedArrays(nums2,nums1);
       }
      
       int left = 0;
       int mid = 0;
       int right = nums1.Length;//want to include all numbers even the last one
      int cutP = 0;
       int leftMin = 0;
       int leftMax = 0;
       int rightMin = 0;
       int rightMax = 0;
       while(left <= right){

        mid = left + (right - left)/2;
        cutP = (((nums1.Length + nums2.Length + 1)/2) - mid);
        leftMin = (mid == 0) ? int.MinValue : nums1[mid -1];
        leftMax = (mid == nums1.Length) ?  int.MaxValue : nums1[mid];
        rightMin = (cutP == 0) ? int.MinValue : nums2[cutP -1];
        rightMax = (cutP == nums2.Length) ? int.MaxValue : nums2[cutP];
        if(leftMin > rightMax){
            right = mid -1;
        }
        else if(rightMin > leftMax){
            left = mid + 1;
        }
        else{
            if((nums1.Length + nums2.Length) % 2 == 0){
               return (double)(Math.Max(leftMin,rightMin) + Math.Min(leftMax,rightMax))/2.0;
            }
            else{
                return (double)Math.Max(leftMin,rightMin);
            }
        }
       } 
       return 0.0;
    }
}
