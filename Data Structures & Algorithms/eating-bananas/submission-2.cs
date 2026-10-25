public class Solution {

    /*
        piles[i] 
        int h -> hours to eat all the bananas

        we can select the eating rate of k 
        every hour select a pile of bananas and eat it 
            if pile is less than k you may eat but cant eat in the pile in till next hour

            minimum integer k need to eat in h hours

            finding the minium amount is going to be the mid point of the rate

            normally in a BS question we are looking for the midpoint of an array
            but a binary search can be applied as mid point of a rate or specific 
            answer.

            we select k a eating rate
            k bananas/hour
            piles = bananas

            piles / k = hours round to the highest since we need to wait

            then tally the total and that would be the total amount of hours

            attempt1: 
                int left = 1;
                int right = Math.Max(piles);
                int mid = 0;
                int totalHours = 0;
                while(left <= right){

                    mid = left + (right - left)/2;
                    totalHours = HowManyTotalHours(mid,totalHours);
                    //how many total hours to take to eat all the bananas 
                    with current rate
                    if(totalHours <= h){
                        return totalHours;
                    }
                    else{
                        left = mid + 1;
                    }
                }
                return -1;

                public int HowManyTotalHours(int mid, int totalHours){

                    for(int i= 0;i < piles.Length;i++){
                        totalHours += Math.Ceiling(piles[i]/mid);
                    } 
                    return totalHours;
                }
    */
    public int MinEatingSpeed(int[] piles, int h) {
        int left = 1;
        int right = piles.Max();//using Linq for finding the max
        long totalHours = 0;
        int mid = 0;

        while( left <= right ){
            totalHours = 0;
            mid = left + (right - left)/2;

            totalHours = FindTotalHours(mid, totalHours, piles);

            if(totalHours <= h){
                right = mid -1;
            } 
            else{
                left = mid + 1;
            }
        }
        return left;//refers to the lowerbound should return that
        
    }
    public long FindTotalHours(int mid, long totalHours,int[] piles){

        for(int i = 0; i < piles.Length;i++){
            totalHours += (long)Math.Ceiling((double)piles[i]/mid); //casting on the right side  integer division rounds before hand must use double before ceiling
        }
        return totalHours;
    }
}


