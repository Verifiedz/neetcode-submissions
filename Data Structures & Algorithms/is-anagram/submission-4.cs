public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length){
            return false;
        }
        char[] sCharArr = s.ToCharArray();
        char[] tCharArr = t.ToCharArray();

        Array.Sort(sCharArr);
        Array.Sort(tCharArr);

        string sortedS = new string(sCharArr);
        string sortedT = new string(tCharArr);

        if(sortedS.ToLower() == sortedT.ToLower()){
            return true;
        }
        return false;
    }
}
