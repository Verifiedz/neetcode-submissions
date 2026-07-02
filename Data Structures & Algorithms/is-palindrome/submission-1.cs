public class Solution {
    public bool IsPalindrome(string s) {
        int left =0;
int right= s.Length -1;

 while(left < right){
    while(left<right && !Alphanumeric(s[left])){
        left++;
    }
    while(right > left && !Alphanumeric(s[right])){
        right--;
    }
    if(char.ToLower(s[left]) != char.ToLower(s[right])){
        return false;
    }
    left++;right--;   
 }
 return true;


bool Alphanumeric(char c){
    return (c>= 'A' && c<= 'Z' || c>='a' && c<='z' || c>= '0' && c<='9' );
}
    }
}
/*

string s want to return true if it satisfies the condition of a palindrome

is a string that reads the same forward and backwards, case-insensitive only aphanumeric chars

example: 

was it a car or a cat I saw?

wasitacaroracatisaw

first to clean the string to have it in the correct format 
compare the string with its reverse.

Clean -> reverse -> compare this would be brute force since we would have to iterate for each char

to make it faster we can do two pointer since two pointer allows us 2 do 2 element processing at a given time

we dont have to iterate and clean then compare we can do it at the same time make sure that it satifies the condition
psuedo code:

int left =0;
int right= s.Length -1;

 while(left < right){
    while(left<right && !Aphanumeric(s[left])){
        left++
    }
    while(right > left && !aphanumeric(s[right])){
        right--;
    }
    if(char.ToLower(s[left]) != char.ToLower(s[right])){
        return false;
    }
    left++;right--;

    return true;

 }
 while(rif)

bool Alphanumaric(char c){
    return (c>= 'A' && c<= 'Z' || c>='a' && c<='z' || c>= '0' && c<='9' )
}
*/