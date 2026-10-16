/*
now to do the question in 0(1) space

to do this: we must 

we cannot modify the nums array and we cannot have more extra space

    we can used a linked list approach ]

    with linked list we can have the numbers be represented as linked list
    when we do that we can check for dups by seeing if there is a cycle 
    if we visit a node more than once.

    detect cycle fast and slow pointers

    int fast = 0;
    int slow = 0;

    fast will go on ahead and loop ahead of slow if they ever overlap again

    then we know that there is a cycle

    1
*/
public class Solution {
     public int FindDuplicate(int[] nums) {
        int fast = 0;
        int slow = 0;
        while(fast <= nums.Length && slow <= nums.Length){

          slow = nums[slow];
          fast = nums[nums[fast]];
 
            if(fast == slow){
                slow = 0;
                while(slow != fast){
                    slow = nums[slow];
                    fast = nums[fast];
                }
                break;
            }
       }    
        return fast;
    }
}
