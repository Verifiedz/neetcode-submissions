public class Solution {

    /*
        arr of n length org in sort asc
            rotated [1...n]
        
        nums = [1...6] -> [3,4,5,6,1,2] rotated 4 times 
            moves elements last 4 to the front 
        in this example 6 will rotate the array back to its og form

        each number is uniqeu return the minum element

        random trivial approaches
    */
    public int FindMin(int[] nums) {
        var set = new PriorityQueue<int,int>();
        foreach( var num in nums){

            set.Enqueue(num, num);
        } 

        return set.Dequeue();
    }
}
