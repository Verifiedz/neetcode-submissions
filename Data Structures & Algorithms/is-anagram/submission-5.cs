public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length!= t.Length){
            return false;
        }

    // we would like to count all the characters in a given string 

       
        Dictionary<char, int> sCount = new Dictionary<char, int>();
        Dictionary<char, int> tCount = new Dictionary<char, int>();

        for(int i = 0; i <s.Length;i++){

            if(!sCount.ContainsKey(s[i])){
                sCount[s[i]] = 1;                
            }
            else{
                sCount[s[i]] += 1;
            }
            if(!tCount.ContainsKey(t[i])){
                tCount[t[i]] = 1;
            }
            else{
                tCount[t[i]] += 1;
            }
        }      
        return sCount.OrderBy(kvp => kvp.Key).SequenceEqual(tCount.OrderBy(kvp => kvp.Key));
    }
}
