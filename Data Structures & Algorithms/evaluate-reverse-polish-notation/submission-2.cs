public class Solution {

    /*
      given string[] of tokens
      the tokens can be operands  -> integers or result of other operations

      the operators considered int the question are + - * /

      example tokens ["1","2","+","3","*","4","-"]

       RPN notation ->  3      9          5

       operation -> xy op
       Left to right 

       two integers one operand 

       -> create a dictionary for operators
       HashSet<string> set = new Hashset<string> { + - * /}

       Stack follows LIFO 

       Stack contains the resulant values while we iterate through the array
       
       keep a count of number of elements in stack

       if element added to stack we increment operCount if 
       operCount = 2 cond that the next element is in hashet set then we pop elements
       decrement operCount when its  = 0 we add result into stack and increment operCount to 1
       
        HashSet  = { + - * /}

        int operCount = 0;

        foreach( string t in tokens){
          
          if(operCount !=2  && !(set.Contains(t))){
          stack.push(int(t));
          operCount++;
          }
          if(set.Contains(t) && operCount ==2){     2 1
             oper2 = stack.pop();
             operCount--;
             oper1 = stack.pop();
             operCount--;
             case(operator):

             case1 = +
               result =  oper1 + oper2
              case1 = -
               result =  oper1 - oper2
              case1 = *
               result =  oper1 *  oper2
              case1 = /
               result =  oper1 / oper2
               stack.push(result)
               operCount++;
          }
        }     
    */
    public int EvalRPN(string[] tokens) {

      HashSet<string> opSet = new HashSet<string>();
      Stack<int> stack = new Stack<int>();
      opSet.Add("+");
      opSet.Add("-");
      opSet.Add("*");
      opSet.Add("/");
      int oper1 = 0;
      int oper2 = 0;
      int result = 0;
      foreach(string t in tokens){

        if(tokens.Length == 1){
          return Int32.Parse(t);
        } 
        
        if(!(opSet.Contains(t))){ // 4 13 5 / +    
          stack.Push(Int32.Parse(t));
          continue; 
        }
        if(opSet.Contains(t)){
          oper2 = stack.Pop();
          oper1 = stack.Pop();
          if(opSet.TryGetValue(t, out string op)){
            switch(op){
              case "+":
                result = oper1 + oper2;
                stack.Push(result);
                break;
              case "-":
                result = oper1 - oper2;
                stack.Push(result);
                break;
              case "*":
                result = oper1 * oper2;
                stack.Push(result);
                break;
              case "/":
                result = oper1 / oper2;
                stack.Push(result);
                break;
            }
          }
        }
      }
      return result;
    }
}
