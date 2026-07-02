public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length){
            return false;
        }
        //since there is fixed number of possible options each letter can be 
        // we will try to create a hash table using an array

        int[] charCounts = new int[26];

        //we need to populate the bucket with characters from both strings

        for(int i = 0; i <s.Length;i++){
            //ascii substraction
            charCounts[s[i] - 'a']++;
            charCounts[t[i]- 'a']--;
        }

        foreach(int count in charCounts){
            if(count!=0){
                return false;
            }
        }

        return true;
    }
}
