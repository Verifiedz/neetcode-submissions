public class Solution {
    public bool IsPalindrome(string s) {
        string finalString = "";

        foreach(char c in s){
            if(char.IsLetterOrDigit(c)){
                finalString += char.ToLower(c);
            }
        }
        string rFinalString =new string( finalString.Reverse().ToArray());
        if(finalString == rFinalString){
            return true;
        }
        return false;
    }
}

// the brute force way of doing it 
// dummystring = '';
// foreach(c in s){ if(char.IsLetterOrDigit(c))(dummstring+=char.ToLower(c))}

//dummyString2 = dummyString.Reverse().ToArray();
//if(dummyString == dummyString2 ) return true 

// return false