public class Solution {
//take a list of strings and turn it into one large encoded string
       // we need a way to combine the strings into one large string and be able to
       //break it back into seperate strings
       //delimiter tells the decoder to seperate the strings at the point
       //Ascii characters
       
       //solution 1: 
       //going to attempt to use a specifc set of character to decode it 
       // we are going to join our encodedSubstring in between each string.
       // we loop through each string and at the end of the string we append the characters
       //and then added to the encodedString to create a large string
/*
       string delimter = "#";
       string encodedFinalString = "";

       for(int i = 0; i< strs.Count;i++){
        encodedFinalString += strs[i];
        if(strs[i] == ""){
            return encodedFinalString = strs[i];
        }
        if(i < strs.Count -1){
        encodedFinalString += delimter;//Hello#World
        }
       }
       return encodedFinalString;
       */
       /* List<string> resultString = new List<string>();
        string[] subs = new string[s.Length];
        subs = s.Split('#');

        foreach(var sub in subs){
            resultString.Add(sub);
        }
        return resultString;

        sol 2:
        we can use the prefix approach:
            -> during the encoding process we count the # of chars in a string
            -> and we add that # along with our delimiter character to represent when a string
            starts
            -> 
            encoding:
            
            example "Hello , World"
            int totalCharacters = 0;
            encodedString = ""
            for(each string in strs){
                foreach(char c in Hello){
                    totalCharacters +=1;
                }
               string delimiter = totalCharacters.ToString() + delimiter(char)
               encodedString  = delimiter + encodedString + delimiter(char)
            }
            return encodedString 

            should return 5#Hello5##World#

            ex     Hello5 World
            6#5#Hello5# 0## 5#World#

            2
            1 checking the number
            2 parsing string
        
        decode:

        the first pass it to find the number and get it as the count in till it hits
        the delimiter (char)

        for(int i = 0; i<s.Length;i++){
        cond: Count #s till it reaches its first delimiter char
        then we start the parser loop
            and add each following character starting from when we found the 
            the delimiter one index after and add those to a local string
            that will be added to the result string, we stop the iteration one we 
            reach the end and the next character is delimter we can escape the loop and go to the start

        }
        */
    public string Encode(IList<string> strs) {

       int totalCount = 0;
       string encodedString = "";
       foreach(string s in strs){
        totalCount = 0;
        foreach(char c in s){
            totalCount+=1;
        } 
        encodedString += totalCount.ToString() + "#" + s;
       }
       return encodedString;
    }
    public List<string> Decode(string s) { 
       List<string> res = new List<string>(); 
       int count = 0;
       bool isHeader= true; 
       string newString = "";
       //lets keep track of modes instead of doing the nested approach with for loops
       char[] sChar = s.ToCharArray();
       int i = 0; 
       while(i < s.Length){
        if(isHeader){
             count = 0;
           while(i < s.Length && sChar[i]!= '#'){
            count = (count * 10) + int.Parse(sChar[i].ToString());
            i++;
           } 
           isHeader = false;
           i++;
         }
         if(!isHeader){
               newString = "";
            for(int k = 0; k < count; k++){
                newString+= sChar[i];
                i++;
            }
            res.Add(newString);
            isHeader = true;
         }
        } 
        return res;
   }
}
