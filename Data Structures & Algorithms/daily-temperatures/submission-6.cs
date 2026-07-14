public class Solution {
    /* array of temp where each temp[i] represents temp on the ith day
    
    return a result array where a particular result[i] is the # of days 
    after the ith day 

    so i in this context of result referes to the day

    example i = 1 and result[i] = 4 before a warmer temp appears on future day.

    if no warmer temp on future day for the ith day the result[i] = 0

    example: 
        temp = [30,38,30,36,35,40,28]
                0  1  2  3  4  5 6

        out =  [1,4,1,2,1,0,0]
                0 1 2 3 4 5 6

                for each index corresponding to a temperature how many days 
                before a warmer temperature arrives
                not including the day of the warmer temperature just days before it 

    Standard approach seems like a nested loop:

    var result = new int[temperature.Length];
    for(int i = 0; i < temperatures.Length;i++){
        for(int j = i+1; j < temperature.Length;j++){
        
            if(stack.Count == 0){
                stack.Push(i);
            } 
            else if(temperature[i] > temperature[j]){
               stack.Push(j);
            }
            else if (temperatures[j] > temperature[i]){
                result[i] = stack.Count;
                stack.Clear(); 
            }
            else{
            result[i] = 0;
            }
        } 
    
    }
    return the result[i];

    

    
    Stack to count the # of days so 
    in this context the number of elements in the stack is going to represent
    how many days before we see a warmer temperature

        we use stack.Peek() to compare the current temp[i] to what is in the stack
        which are the temperatures associated to the # of days that are less than the 
        are starting point
    */

    public int[] DailyTemperatures(int[] temperatures) {

        var res = new int[temperatures.Length];
        bool daysFound = false;
        Stack<int> daysCount = new Stack<int>();
        for(int i = 0; i < temperatures.Length;i++){
        daysFound = false;
        daysCount.Clear();
            for(int j  = i + 1; j < temperatures.Length; j++){
               
               if(daysCount.Count == 0){ 
                daysCount.Push(i);
               }
               if (temperatures[i] >= temperatures[j] && daysFound == false){
                 daysCount.Push(temperatures[j]);
                 res[i] = 0;
               }
               if ((temperatures[i] < temperatures[j]) && daysFound == false){
                res[i] = daysCount.Count;
                daysCount.Clear();
                daysFound = true;
               }
            }
        }
        return res;
    }
}
