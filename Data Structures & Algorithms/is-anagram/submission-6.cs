/*
anagram is when we have the same number of letters in a word that can be 
rearranged to form another valid word example 

cat act both contain 3 letters and are arranged in 2 distinct words

*/

public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length){
            return false;
        }
       Char[] sChar; //remember to initialize
       Char[] tChar;
        sChar = s.ToCharArray();
        tChar = t.ToCharArray();

        Array.Sort(sChar);
        Array.Sort(tChar);

        if(sChar.SequenceEqual(tChar)){
            return true;
        }
        return false;

    }
}
