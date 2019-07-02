class Solution:
    def lengthOfLastWord(self, s: str) -> int:
        arr = s.split(" ")
        if len(arr) == 0:
            return 0
        for i in range(len(arr)-1,-1,-1):
            if len(arr[i]) != 0:
                return len(arr[i])
        return 0
