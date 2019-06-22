class Solution {
public:
    int reverse(int x) {
        int reverse = 0;
        while(1)
        {
            reverse += x%10;
            x/=10;
            if(!x)break;
            if((long)reverse * 10 > 2147483647l || (long)reverse * 10 < -2147483647l)return 0;
            reverse *= 10;
        }
        return reverse;
    }
};
