public class Solution {

    /*
        trivial approach two

            brute force loop and update the minium
    */
    public int FindMin(int[] nums) {
        var min = 100;
        foreach(var num in nums){
            if(num < min) min = num;
        }
        return min;
    }
}
