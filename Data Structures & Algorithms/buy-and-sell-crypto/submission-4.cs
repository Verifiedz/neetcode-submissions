public class Solution {

    /*
    given arr of prices 
    prices[i] is price of Neetcoin on the ith day

    choose a day to buy the coin
    choose a day to sell the coin

    can choose to make no transaction 

    profit would be 0 
    prices = [10,1,5,6,7,1]

    left pointer would be the day we buy the stock
    right pointer would be the day we sell the stock

    we move the right pointer one day at a time 
    check the profit that can be made at the time if we were to buy 
    
        profit = prices[right] - prices[left] > 0 or higher than previous profit value

            we move the left pointer to buy only after we get a higher profit

            left and right start at 0 

            right will move with the for loop each iteration 
            and calculate profit

            left on the other hand will only move if a better 
            buy price comes, which if the number for sell is lower than buy then 
            it will increment left for next iteration

     prices = [10,1,5,6,7,1]
        l:0 1 
        r:1 2 3 4 5
        p:0 4 6
        mP:0 4 6       

    prices = [10,8,7,5,2]
        l:0 1 2
        r:1 2 2
        p:0 0 0 
        mP:0 0 0    



            int left = 0;
            int right = 1;
            int profit = 0;
            int maxProfit = 0;
            for(right < prices.Length;right++){

                if(prices[right] - prices[left] > 0) profit = prices[right] - prices[left];

                if(prices[right] < prices[left]) left++;

                if(maxProfit < profit) maxProfit = profit; 
            }
            return maxProfit;


    1 - 7 = 
prices=[2,1,2,1,0,1,2]
l 0 1 1
r 1 2 3
p 0 0 1

    */
    public int MaxProfit(int[] prices) {

        int l = 0;
        int profit = 0;
        int maxProfit = 0;
        for(int r = 1; r < prices.Length;r++){
            if(prices[r] - prices[l] >= 0) profit = prices[r] - prices[l];
            
            while(prices[r] < prices[l] && l!=r) l++;

            if(maxProfit < profit) maxProfit = profit;
        } 
        return maxProfit;
    }
}
