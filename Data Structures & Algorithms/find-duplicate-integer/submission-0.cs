/*
 arr with n + 1 integers 
    each int is in range of [1, n]

    there is exactly one repeated number return the repeated number

*/
public class Solution {
    public int FindDuplicate(int[] nums) {
        int number= 0;
        HashSet<int> set = new HashSet<int>();
        foreach(var num in nums){
            if(!set.Contains(num)){
                set.Add(num);
            }
            else{
                    number = num; 
            }
        }
        return number;
    }
}
