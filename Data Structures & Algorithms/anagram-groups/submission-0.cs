public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        Dictionary<string, List<string>> dCount = new Dictionary<string, List<string>>();      
       
        for(int j = 0;j<strs.Length;j++){
            char[] cString = strs[j].ToCharArray();
             Array.Sort(cString);
             string sorted = new string(cString);
             if(!dCount.ContainsKey(sorted)){                                      
                dCount[sorted]=new List<string>{strs[j]}; 
             }
             else{                                      
                dCount[sorted].Add(strs[j]);
             }         
        }       
        return dCount.Values.ToList();
    }
}
// the key of the hashmap would be the number of character in alphabetical order
// the values would be the list of characters that are related to those characters 
// after which we issue out the result of the dictionary into a new List<string> array