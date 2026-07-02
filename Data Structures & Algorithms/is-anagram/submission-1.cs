public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length!=t.Length){
            return false;
        }

        var sSort = s.ToCharArray();
        var tSort = t.ToCharArray();

        Array.Sort(sSort);
        Array.Sort(tSort);
        if(sSort.SequenceEqual(tSort)){
            return true;
        }
        else{
            return false;
        }
    }
}
