public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        
        int l = 0;
        int r = numbers.Length -1;
 // -5 -3 0 2 4 6 8
        while(l<r){

            while(l<r && numbers[l]!=numbers[r]){

                if(numbers[l]+numbers[r]!=target){
                    r--;
                }
                else{
                    return new int[]{l+1,r+1};
                }
            }
            r = numbers.Length-1;
            l++;
        }
        return null;      
    }
}
// numbers = [1,2 ,3, 4],
// target = 3
// since its in increaseing order we we can use two pointers and compare the two elements
// to see if they add up to the target
// we need one loop where we increment one pointer and only increment the other pointer only after it has gone through each
//element to look for target

// lets say pointer1 = l 
//the second pointer2 is r will start at 4 then go 3..2..ignoring the one case since index1 cant be index2
//after we have reached the point that left is >=right we increment the left
// so now in the example it will be 2 and then we rest right
//once we get the two numbers that are the target we can we can return a int[] with there numbers