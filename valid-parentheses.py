class Solution:
    def isValid(self, s: str) -> bool:
        dictionary = ['(', ')', '{', '}', '[', ']']
        stack = [ ]
        for c in s:
            if dictionary.index(c)%2 == 0:
                stack.append(c)
            else :
                if len(stack) ==0 : return False
                open_b = stack.pop()
                if dictionary.index(open_b) != dictionary.index(c) - 1:
                    return False
        if len(stack) : return False
        return True
