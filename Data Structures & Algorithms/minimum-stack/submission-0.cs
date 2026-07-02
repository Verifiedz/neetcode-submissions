public class MinStack {
/*
I need to create a minimum stack that is able to get the minimum or smallest value 
The built in c# library already has LIFO structure for stacks-meaning we already have functions 
that can do "Push(val)" and Pop() and the Top() is another way of using Peek();
ex
Stack: 
1
2
0
getMin() returns the smallest number without removing the element
Pop() then removes 
Stack: 
2 
0
if we call Top it returns the value at the top which we can access with Peek();

How can we getMin() in O(1) time 

normally if we were to iterate through the stack it would be O(N) to be able to find the element
if there are n elements in the stack
but if we use a second stack to store the minium values in order of LIFO so it stores
the absolute lowest value in in its stack so it would only have one single element
and then push that whenever it is the lowest 
so in the context of 

1
2 
0
since 0 is the lowest we would only store that in the minStack and remove all the elemtns that come
beforei t by comparing it 

methods are only called on non-empty stacks
the minStack should be lowest are last out the last in are higher values which are first out
1
2
0
*/
Stack<int> mainStack;
Stack<int> minStack;
    public MinStack() {
        mainStack = new Stack<int>();
        minStack = new Stack<int>();
    }
    
    public void Push(int val) {
     if(mainStack.Count != 0){

        mainStack.Push(val);

        if(minStack.Peek() >=val){// if new val is smaller store
            minStack.Push(val);
        }
        else{
            minStack.Push(minStack.Peek()); //then push smaller
        }
     }
     else{
        mainStack.Push(val);
        minStack.Push(val);
     }
    }
    
    public void Pop() {
    mainStack.Pop(); 
    minStack.Pop();        
    }
    
    public int Top() {
        
        return mainStack.Peek();
    }
    
    public int GetMin() {
       return minStack.Peek(); 
    }
}
