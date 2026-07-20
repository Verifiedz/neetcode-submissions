public class Solution {

    // temp = [30,38,30,36,35,40,28]
    // monotonkic stack
    // the stack will place elements
    /*
    store elements in the stack based on a condition of when a warmer temperature would be 
    seen 

    example  temperatures = [30,38,30,36,35,40,28]
    the goal of the monotonic stack is to store unresolved history

    does that mean elements are stored under the condition there conditons are not 
    met right way

 temperatures = [30,38,30,36,35,40,28]

    Stack<int> DaysTemp = new Stack<int>();
    int[] res = new[Temperatures.Lenght];
    for(int i = 0; i < temperatures.Length;i++){
         
         res[i] = 0;
         while(!(DaysTemp.Count == 0) && temperatures[i]  > temperatures[DaysTemp.Peek()]){
         
            res[i] = (i) - DaysTemp.Pop();
         }
         DaysTemp.Push(i);
         return res;
    }
     
    */
    public int[] DailyTemperatures(int[] temperatures) {

        Stack<int> days = new Stack<int>();
        int[] res = new int[temperatures.Length];

        for(int i = 0; i < temperatures.Length;i++){

        res[i] = 0;
        if(i == 0) days.Push(i);
        while(days.Count != 0 && temperatures[i] > temperatures[days.Peek()]){

            res[days.Peek()] = i - days.Pop();
        }
        if(i!=0 ) days.Push(i);
        }     
        return res;
        // 
    }
}
