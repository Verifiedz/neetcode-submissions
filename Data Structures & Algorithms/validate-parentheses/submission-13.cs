public class Solution {
    public bool IsValid(string s) {
        /*
        given s(string) only set chars

        need to test to see if a string is valid

        we can use a dictionary to keep track of if a close bracket comes we have the appropriate
        open bracket before it

        since we need to see that the parantheses are in order we can use a stack

        that uses LIFO and pop each time that we see a open brack after recieving a closed one

        we can store the kvp in a dictionary
        
        we have an if conditional check if we recieve a bracket that does not correspand and return
        false in that case

        */

        Dictionary<char,char> sDict = new Dictionary<char,char>{
            {')','('}, {'}','{'}, {']','['},
        };
        Stack<char> sStack = new Stack<char>();

        foreach(char c in s){

            if(!sDict.ContainsKey(c)){
                sStack.Push(c);
            }
            else{
                if (sStack.Count == 0){
                    return false;
                }
                if(!(sStack.Peek() == sDict[c])){
                    return false;
                }
                else{
                    sStack.Pop();
                }
            }
        }

        return sStack.Count == 0 ? true: false;
    }
}
