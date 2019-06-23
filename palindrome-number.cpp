class Solution {
public:
    bool isPalindrome(int x) {
        if(x<0)return 0;
        long reverse = 0,y=(long)x;
        long n = (long)x;
        while(1)
        {
            reverse += n%10;
            n/=10;
            if(!n)break;
            reverse *= 10;
        }
        if(reverse == y)return true;
        return false;
    }
};
