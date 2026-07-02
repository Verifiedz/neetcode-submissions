public class Solution {
    public bool IsValid(string s) {

        Stack<char> charStack = new Stack<char>();
        Dictionary<char, char> dict = new Dictionary<char, char>{
            {')','('},
            {'}','{'},
            {']','['},
        };
        foreach(char c in s){
            if(dict.ContainsKey(c)){
                if(charStack.Count > 0 &&charStack.Peek() == dict[c] ){
                    charStack.Pop();
                }else return false;
            }
            else{
                charStack.Push(c);
            }
        }
        return charStack.Count == 0;       
    }
}
// []

/*"([{}])" 


(

    stack ([{
*/
