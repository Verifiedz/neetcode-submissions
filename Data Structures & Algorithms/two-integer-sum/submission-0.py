from collections import defaultdict
class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:

        """
        we want assign keys to every number in the nums array to serve as a unique identifier to its respected index 
        we then go through the list extract numbers first set the condition that that i!=j 


        psuedo code 
        Note use the python enumerate on a tuple to return the index 
        nums_map = defaultdict(list)
        we also need intialize our hashmap which we can just do with a simple for loop 

        int i, j, 
        result =[]
        for s in nums:
            nums_map =[nums].append(s)
        
        if statment to compare and check that the sum of the two indices match our target 

            if i!=j && sum(i,j)== target:


            for value in enumarate(nums_map.values()):
                result.append(value)


        """
        nums_map = {}

        for i,j in enumerate(nums):
            diff = target - j

            if diff in nums_map:
                return [nums_map[diff],i]
            nums_map[j] = i