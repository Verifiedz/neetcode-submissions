public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

    Dictionary<string,List<string>> dict = new Dictionary<string, List<string>>();
    
    foreach (string str in strs){
        char[] charStr = str.ToCharArray();
        Array.Sort(charStr);
        string stringKey = new string(charStr);
        if(!dict.ContainsKey(stringKey)){
            dict.Add(stringKey,new List<string>{str});
        }
        else{
            dict[stringKey].Add(str);
        }
       
    }
     return new List<List<string>>(dict.Values);
    }

}



