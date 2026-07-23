public class Solution {
    /*
        from input string s we need to find the longest substring
        with not dup

        sliding window approach(worm variation)

        int left = 0;
        int finalCount = 1;
         var count = 1;

        ex :s = "zxyzxyz"
        ex :s = "xyyyx" 
        l 
        r 
        c 
        fc
        for(int right = 0; right < s.Length;right++){
            if(s[right]!=s[left]){
                count++;
            }
            else if (s[right] == s[left]){
                
                while(s[left] != s[right]){s
                    left++;
                }
             if(count > finalCount) finalCount = count;
             count = 1;
            }
        }
        return finalCount;
    */
    public int LengthOfLongestSubstring(string s) {
          // pwwkew 
         int left = 0;
        int finalCount = 0;
        HashSet<char> set = new HashSet<char>();
         if(string.IsNullOrEmpty(s)) return 0;
         for(int right = 0; right < s.Length;right++){

            if(!set.Contains(s[right])){
                set.Add(s[right]);  //a :0  a:1
            finalCount = right  - left + 1 > finalCount?  right - left + 1  : finalCount;
            }
            else{//[] 
                while(set.Contains(s[right])){
                    set.Remove(s[left]);
                    left++;
                }
                set.Add(s[right]);
            }
            finalCount = right  - left + 1 > finalCount?  right - left + 1  : finalCount;
         }
         return finalCount;

    }

}