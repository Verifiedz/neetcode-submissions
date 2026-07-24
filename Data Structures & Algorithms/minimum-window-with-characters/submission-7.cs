public class Solution {


    /*
    two strings s and t and return the shortest substring

    of s with every char of t(including dupes) is present in the substring
    return empty string if no such substring
    
    unique correct output

    t can be larger than s
    
    s and t can be both lower and upper case 
    sol must work for both

    right pointer is going to move intill there is no chars from t
    we can do this by having a bucket for t

        foreach char if char in s matches t have + 1 need

        when need == have

        we have all the specific chars I need 

        and can move the left pointer 

        if(char in s matchs char in t again, then have --)

        and the right pointer can start moving again.
        
        each time after right moves
            we can note down the size of the window and keep track of it 
        
        when the window is valid which is when the need matches have
        we can note down the current window lenght




    */ public string MinWindow(string s, string t) {  int[] countT = new int[128];
        int[] windowBucket = new int[128];
        int need = t.Length;
        int have  = 0;
        int left = 0;
        int bestLeft = 0;
        int minLength = s.Length;
        string subString = "";
        if(s.Length < t.Length){
            return "";
        }
        

        //fill out target arr to then be used in comparison
        for(int i = 0; i < t.Length;i++){
            countT[t[i]]++;
        }

        for(int right = 0; right < s.Length;right++){
            //right pointer moves
            windowBucket[s[right]]++;
            if(windowBucket[s[right]] <= countT[s[right]]){
                have++;
            }

            while(have == need){
               if(minLength > (right - left + 1)){
                minLength = right - left + 1;
                bestLeft = left;
               }
               subString = s.Substring(bestLeft,minLength);
               if(windowBucket[s[left]] == countT[s[left]]){
                    have--;
                }
                windowBucket[s[left]]--;
                left++;
            }
        }
        return subString;
    }
}
