class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        """
        so anagram is where we have two words that are the same letters that rearrange into different words lik eat and tea

        we can sort the letters compare if they are equal then return true 

        sorted_s = sorted(s)
        sorted_t = sort(t)

        if sorted_s == sorted_t
            return True
        """

        sorted_s = sorted(s)
        sorted_t = sorted(t)

        if sorted_s == sorted_t:
            return True

        return False
        