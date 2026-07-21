public class Solution {
    /*
    with arr of heights we need to find largest area

    each bar has as width of 1 

    monotonic stack would be used.

    iterate heights.Length:

    push the index of the bar on the stack

    cond: compare the heights of the prev to the current bar
        if smaller it means the rectangle cant be extended
        the value must be popped out and the Area must be caculated

        if taller then the rectangle can continue so we note the index

        the index will be used for the width to see the largest rectangle we can make 
        with that index and stop only if at the end or if a smaller rectangle is 
        found

        for the example 
        heights = [1,3,7] 

        push i = 0
        at i = 1 the height 3 > than 1 so we can extend the rectangle add 
        1 to the stack 
        i = 2 we see 7  > 3 so it can continue 
            add 2 to te stack and calculate 
            area = 7 x 1

        then go down the stack and pop the next rectangle 
        for each index and maintain the largest rectangle

        a monotonic stack:
         - keeps track of unresolved history for multople points 

         - if the right condition for storing and removin elements from the stack
         the stack will resolve itself. 
         - keep track of elements and removing them when there conditions do not meet

        Stack<int> index = new Stack<int>();
        int maxArea = 0;
        int width = 1;

        ex [1 , 3 , 7 ]

        [7,1,7,2,2,4]
stack [0,1,2]

        for(int i = 0; i < heights.Length;i++){
            int currArea = 0;     
            index.Push(i);
            while(index.Count != 0 && heights[i] < heights[index.Peek()]){
               width += i - index.Peek();
               currArea = heights[index.Peek()] * (width);
               index.Pop();
            }
        }

        //clean up loop if elements remain on stack
        
        while(index.Count != 0){
            currArea = heights[index.Peek()] * (width);
            index.Pop(); 
            width++;
        if(currArea > maxArea) maxArea = currArea;  7 
  */
    public int LargestRectangleArea(int[] heights) {

        Stack<int> bar = new Stack<int>();
        int maxArea = 0;
        int width = 0;
        int height = 0;
        int currArea = 0;
//process iteration for each bar to elimate bars when it gets cut of 
// by a lower heighta
// [2, 1, 2]
//stack: [1,2]  1-0  = 1 
// maxArea: 2
// 3-2 1   area = 2
// 3 - 1 2 1x2 
        for(int i = 0; i < heights.Length;i++){
            currArea = 0;
            while(bar.Count !=0 && heights[i] < heights[bar.Peek()]){
                height = heights[bar.Peek()]; 
                bar.Pop();
            if(bar.Count == 0) {
                width  = i;
            }
            else{            
                width = i - bar.Peek() - 1;
            }     
                currArea = height * (width);
                if(maxArea < currArea) maxArea = currArea;               
            }
            bar.Push(i);
            width = 0;
        }
        //cleanup
        while(bar.Count != 0){
            width = heights.Length - bar.Peek() - 1;
            height = heights[bar.Peek()];
            bar.Pop();  
            if(bar.Count == 0) {
                width = heights.Length;
            }
            else{
            width = heights.Length - bar.Peek() - 1;
            }     
            currArea = height * (width);
            if(maxArea < currArea) maxArea = currArea; 
        }
        return maxArea;
    }
}
