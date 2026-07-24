public class Solution {
    /*
    Inch worm approach

    string s only upper case letters 
    
    integer k 
    can replace up to k  upper letters from the string

    after k replacements return the length of the longest substring
    which contains only one distinct character

    right pointer of the window increments each iteration
    and add the char to the hashset

    breaker cond: when a repeated character is spotted
    we need to fix the repeated character to make the window valid

    we do that by the left pointer

    which will loop intill it removes that said character 
    after we can add the current character back in

    we can note down the window and continue to move on 

    we just need to keep counting the substring with one character 

    in either a frequency map or a counting bucket

    and then to return the length

    we can get right - left + 1 to get the current max length

    right: moves each iteration counting
    
    left pointer is there to correct the frame
    once  repeated character is spotted we need to replace with K if we can
    continue the count 


    int finalCount = 0;
    int[] count = new int[26];
    int left = 0;
    
    
    for(int right = 0; right < s.Length;right++){
         while(!(count[s[right] - 'A'] > 0)){ when the cond is invalid
           
            if(k!= 0){
            count[s[right -1 ] - 'A']++;
            k--;
           }
           else{

           while(left != right){
             finalCount = Math.Max(finalCount,count.Length);
            count[s[left] - 'A']--;
            left++;   
           }
           }
         }
         count[s[right] - 'A']++;
    }








    */
    public int CharacterReplacement(string s, int k) {

    int maxFreq = 0;
    int finalCount = 0;
    int[] count = new int[26];
    int left = 0;
        
        for(int right = 0; right < s.Length;right++){
            count[s[right] - 'A']++;
            maxFreq = Math.Max(maxFreq, count[s[right] - 'A']);
            while((right - left + 1 ) - (maxFreq) > k){ 
                count[s[left] - 'A']--;
                left++;
            }
            finalCount= Math.Max(finalCount, right - left + 1);    
        }
        return finalCount;
    }
}
