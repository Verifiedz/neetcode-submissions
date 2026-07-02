public class Solution {
    // need to group strs in to a list that have the same amount of chars
    public List<List<string>> GroupAnagrams(string[] strs) {

        Dictionary<string,List<string>> freq = new Dictionary<string,List<string>>();
        List<List<string>> results = new List<List<string>>();
        for(int i = 0; i< strs.Length;i++){

            var sortingStringKey = strs[i].ToCharArray();
            Array.Sort(sortingStringKey);
            var keyString = new string(sortingStringKey);

            if(!freq.ContainsKey(keyString)){
                freq[keyString] = new List<string>{strs[i]};
            }
            else{
                freq[keyString].Add(strs[i]);
            }
        } 
        results = freq.Values.ToList();
        return results;
        
    }
}
