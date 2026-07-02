/*
 we have a list of strings strs that contains a list of anagrams we need to group all the pairs of anagrams int seperate 
 sub lists

 psuedo code:

 create a hashmap and create a dictionary of type list that will contain all the anagrams that are the same
 and if the number of characters match it will add it to that dictionary value 

then add each character after sorted list and append it to the dictionary




        sorted s will be in dictionary and the count will be updated s will be issued out in a new list

        act -> act act
        cat -> act cat 

        act -> [cat, act]
*/

public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        List<List<string>> listOfStrings = new List<List<string>>();
        
        Dictionary<string,List<string>> count = new Dictionary<string, List<string>>();
        
        for(int i = 0; i<strs.Length; i++){           
            char [] sorted = strs[i].ToCharArray();
            Array.Sort(sorted);           
            string sortedString = new string(sorted);

            if(!count.ContainsKey(sortedString)){
                count[sortedString] = new List<string>(); 
                count[sortedString].Add(strs[i]);
            }
            else{
                count[sortedString].Add(strs[i]);
            }
        }
        foreach(var key in count){
            listOfStrings.Add(key.Value);
        }
        return listOfStrings;       
    }
}