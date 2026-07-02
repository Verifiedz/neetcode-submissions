public class Solution {

    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> triplet = new List<List<int>>();
        HashSet<string> dup = new HashSet<string>();
        for(int i = 0; i < nums.Length; i++){
            for(int j = 0; j < nums.Length; j++){
                for(int k = 0; k < nums.Length; k++){ 
                    if(i == j || j == k || i == k){
                        continue;
                    }
                    else{
                        string key = $"{nums[i]},{nums[j]},{nums[k]}";  
                        char [] sorting = key.ToCharArray();
                        Array.Sort(sorting); 
                        key = new string(sorting);                
                        if( !dup.Contains(key) && nums[i] + nums[j] + nums[k] == 0){
                            triplet.Add(new List<int>{nums[i], nums[j], nums[k]});
                            dup.Add(key);  
                        }         
                    }                   
                }
            }      
        }        
        return triplet;
    }
}
