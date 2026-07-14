public class Solution {
    /*
    n cars
    one lane highway
    2 arrays of int position and speed both of length n 
    position[i] the position of the ith car
        -> where is the car in the highway
        -> speed of the car on the highway
    
    target represents the destination in miles

    since its a single lane highway

    rules:
        ->car cannot pass a car ahead only catch up and then drive the same speed as the car
        infront of it
        
        "car fleet" non empty set of cars driving at the same pos and speed
            -> even if there is one car its in car fleet with itself
        -> if the car fleet reaches target and another that is not in the fleet
           reaches the target at the same time as the fleet its also considered part of the
           fleet
    
    return: then number of different car fleets that will arrive at the destination

    example: 10 miles destination, position[1 mile, 4th mile], speed [3,2]miles/h

    out = 1   car 1 3 6  10 speed is 3 -> 2
              car 2 4 6 10 speed is 2

              keep track of car fleets: 
              cond: if a car behind a car reaches the same pos then first car is part 
              fleet of the second car and the speed is the same 
              we set the speed of the first car to the speed of the second
              this becomes a car fleet. 

              keep track of when a car fleet reaches a destination they are not moving 
              anymore
speed 2 2 1 1            
# of fleets: 3 

        4 6 8 10
        1 3 5 7  9 10
        0 1 2 3  4 5 10
        7 8 9 10

        Only after a car catches up is it combined into a fleet 
        
        need to have the pos and speed together 
        create a 2d array that will store the pos and speed.

        No need to simulate each car moving rather just need to know when each car
        would arrive and who would arrive faster 

        Distance / Time = speed  
        Time = Distance/ speed

        sort the 2d array with pos and speed and then iterate and see whose time 
        is faster if its slower than car ahead combine them into a fleet 

        the cars will be placed in order

        we can use to stack to create the fleet
        we push a car into the stack if it arrives with other cars
        and then pop the stack once a particular fleet is done
        if a car is slower than the LIFO car its not part of that fleet and would be part of its 
        on fleet when this happens we can empty the stack and incrememt our car fleet variable
        and we do the same with the next set of cars and compare the LIFO car to the car
        before

        sol: 

        Stack<double> carFleet = new Stack<double>();
        //Create an array of Tuples
        (double, double)[] carArr = new (double,double)[position.Length];
        for(int i = 0; i< position.Length;i++){
        carArray[i] = (position[i],speed[i]); 
        }

       Array.Sort(carArr[i]);

       for(int i = position.Length -1; i >= 0;i--){
        double currDistance = target - carArr[i].Item1
        double currTime = currDistance/carArr[i].Item2;
        double nextDistance = target - carArr[i-1].Item1
        double nextTime = nextDistance/carArr[i-1].Item2;
        int countFleet = 0; 
        carFleet.Push(currTime);
        if(nextTime < currTime){
           carFleet.Push(prevTime);
        }
        if(nextTime > currTime){
           countFleet = carFleet.Count;
           carFleet.Clear(); 
        }


       }
         return countFleet;

        
    */
    public int CarFleet(int target, int[] position, int[] speed) {

      Stack<double> carFleet = new Stack<double>();

      // we need to combine the arrays to a new tuple array
      (double, double)[] carArr  = new (double,double)[position.Length];

      for(int i = 0; i < speed.Length;i++){

        carArr[i] = (position[i],speed[i]); 
      }

      Array.Sort(carArr);// (0,1), (1,2) (4,2) (7,1)
      
      for(int i = speed.Length - 1; i >= 0;i--){
        double currDistance = target - carArr[i].Item1; // 10 - 7 = 3
        double currTime = currDistance/carArr[i].Item2; // 3/1  = 3

        if(carFleet.Count == 0){ // (3 5/2)  9/2  10
            carFleet.Push(currTime); 
        }       // 1 7 12
        else if(currTime <=carFleet.Peek()){// for state changes use else if
            
        }
        else if(currTime > carFleet.Peek()){
            carFleet.Push(currTime);
        }
      }
      return carFleet.Count;
    }
}
