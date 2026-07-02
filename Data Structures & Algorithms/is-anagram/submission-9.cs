public class Solution {
    public bool IsAnagram(string s, string t) {

        // anagram 2 words with the same # of letters

        // s.Length == t.Length
        // create a dict freq array to count the freq of each 
        // char in each of the strings
        //convert the string into a char array

        Dictionary<char,int> sdict = new Dictionary<char,int>();
        Dictionary<char,int> tdict = new Dictionary<char,int>();

        
        if(s.Length !=t.Length){
            return false;
        }
        char[] sChar = s.ToCharArray();
        char[] tChar = t.ToCharArray();

        for(int i = 0; i < s.Length;i++){

            if(!sdict.ContainsKey(sChar[i])){
                sdict[sChar[i]] = 1;
            }
            else{
                sdict[sChar[i]]++;
            }
            if(!tdict.ContainsKey(tChar[i])){
                tdict[tChar[i]] = 1;
            }
            else{
                tdict[tChar[i]]++;
            }
        }
        return sdict.OrderBy(kvp =>kvp.Key).SequenceEqual(tdict.OrderBy(kvp=>kvp.Key));
    }
}
