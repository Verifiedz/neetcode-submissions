from collections import defaultdict
class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:

        """
        if a number repeats in a given list return true else return false 
        intialize a empty hashmap add values to hashmap if there exists no values, and if there is a repeat value to check 
        we compare to hashmap if it exists if it does return true 

        nums_map = {}

        for s in nums:
            
            if s in nums_map:
                return True
            else:
                nums_map[s] +=1
        
        return False
        """
        nums_map = defaultdict(int)

        for s in nums:

            if s in nums_map:
                return True
            else:
                nums_map[s] +=1
        return False