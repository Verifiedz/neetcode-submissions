public class Solution {
    public int Trap(int[] height) {

       // each bar has a width of 1 
       // if the height[i] has a value there is a bar where water can reside
       // this is depended on the maximum height of the bars around it whether water
       // can be stored on top 
       // it would be hard to determine the boundarys of where water can be stored
       // check the vertical height of water per index
       //check the current index in comparision to the max of the left tower and the right 
       // if the index is equal or shorter then both the left and thright water can be stored
       // in that area

       int l = 0;
       int r = height.Length -1;
       int maxL = height[l];
       int maxR = height[r];
       int totalArea = 0; 

       while (l < r){

        maxL = Math.Max(maxL,height[l]);
        maxR = Math.Max(maxR,height[r]);

        if(maxR == maxL && (height[l]!=maxL || height[r]!=maxR)){
            if(height[l]!=maxL){
             totalArea += maxL - height[l];
            l++;    
            continue;
            }
            if(height[r]!=maxR){
             totalArea += maxR - height[r];
             r--;
             continue;
            }
        }
        if(maxL < maxR && height[l]!=maxL){
            totalArea += maxL - height[l];
            l++;
            continue;
       } 
       if(maxR < maxL && height[r]!=maxR){
          totalArea += maxR - height[r];
          r--;
          continue;
       }
       else if(maxL < maxR){
        l++;
        continue;
       }
       else{
        r--;
        continue;
       }
       }
       return totalArea;
    }
}