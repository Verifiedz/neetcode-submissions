public class Solution {

    /*
    given two strings s1 and s2
    return true if s2 contains a permutation of s1 or false

    return true if a permutation of s1 exists in s2

    only lower case

    example:

    s1 = "abc", s2 = "lecabee"

    permutation can have the string arranged in any way as long as the 
    letters of of the string are together

    two pointer approach fixed window
    the size of the window is dependent on the s1.

    create a count bucket and fill it up with the count of s1
        int[] count = new int[26];
        int left = 0;
        int right = s1.Length - 1;

        for(int i = 0; i < s1.Length;i++){
            count[s1[i] - 'A']++;
        }
       while(right < s2.Length){
            count[s2[left] - 'A']--;
            foreach(int val in count){
                if(val ! = 0){
                    right++;
                    left++;
                }
                else{ 
                return true;
                }
            }
       } 
       return false;   
    */
    public bool CheckInclusion(string s1, string s2) {

        int[] countS1 = new int[26];
        int[] countS2 = new int[26];
        int left = 0;
        int right = s1.Length - 1;

        if(s1.Length > s2.Length){
            return false;
        }
        for(int i = 0; i < s1.Length;i++){
            countS1[s1[i] - 'a']++;
        } //count bucket s1 = "AB"  A: 1 B: 1 s2 = CCAB

        // need to fill up the first bucket of s2


        for(int j = left; j < right + 1 ;j++){
            countS2[s2[j]-'a']++;
        }
        while(right < s2.Length){       //
            if(countS1.SequenceEqual(countS2)){
                return true;
            }
            countS2[s2[left] - 'a']--;
            left++;
            right++;
            if(!(right < s2.Length)) break;
            countS2[s2[right] - 'a']++;
           
        }
        return false;
    }
}
