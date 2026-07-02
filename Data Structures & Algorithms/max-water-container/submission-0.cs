public class Solution {
    public int MaxArea(int[] heights) {

        int maxArea = 0;
        int currentArea = 0;
        int l = 0;
        int r = heights.Length -1;

        while(l<r){

            if(heights[l] > heights[r]){
                currentArea = heights[r]*(r-l);
                if(currentArea > maxArea){
                    maxArea = currentArea;
                }
                r--;
            }
            else if(heights[l] < heights[r]){
                currentArea = heights[l]*(r-l);
                if(currentArea > maxArea){
                    maxArea = currentArea;
                }
                l++;
            }
            else{
                currentArea = heights[l]*(r-l);
                if(currentArea > maxArea){
                    maxArea = currentArea;
                }
                l++;
            }
     
        }
        return maxArea;
    }
}
// we need to determine the Area
// we can keep track of the area a var for currentMaxArea
//and then use a final variable for the final max
// we will use a two pointer approach and iterate
// left and right pointers to keep track area
//we need conditions on when to move the pointer
//we take the lowest height between the pointers 
// and get the currentArea and then we assign that as the max area if it bigger
//after which we have checks for both left and right pointers to see the next area if it is bigger
//or if it smaller and move accordinly to that