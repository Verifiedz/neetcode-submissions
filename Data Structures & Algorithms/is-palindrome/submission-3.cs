public class Solution {
    public bool IsPalindrome(string s) {

        
        int left = 0;
        int right  = s.Length -1;

        //w a s i t a c a r o r a c a t i s a w

        // _ a _
        //w o ? ? w ?

        char[] charArray = s.ToCharArray();

        while(left < right){

            while(left < right && !char.IsLetterOrDigit(charArray[left])){
                left++;                
            }
            while(left < right && !char.IsLetterOrDigit(charArray[right])){
               right--;
               
            }
            if(char.ToLower(charArray[left]) == char.ToLower(charArray[right])){
                left++;
                right--;
            }
            else{
                return false;
            }
            
        }
        return true;
    }
}
// need a way to ignore non alphanumeric characters
//then I have 2 pointers one on the left and the other on the right
// incrementing and decrementing and comparing each character if they are the 
// same it is a palindrome

