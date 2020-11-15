class Solution(object):
    def subtractProductAndSum(self, n):
        """
        :type n: int
        :rtype: int
        """
        productOfDigits = sumOfDigits = 0
        if n > 0:
            productOfDigits = 1
        while n > 0:
            x = n % 10
            n/=10
            productOfDigits *= x
            sumOfDigits += x
            
        diff = productOfDigits - sumOfDigits
        return diff
        
