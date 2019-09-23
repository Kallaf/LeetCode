// Forward declaration of guess API.
// @param num, your guess
// @return -1 if my number is lower, 1 if my number is higher, otherwise return 0
int guess(int num);

class Solution {
public:
    int guessNumber(int n) {
        int l = 1,r = n;
        while(l<r)
        {
            int middle = l+((r-l) / 2);
            int res = guess(middle);
            if(res == -1)r = middle-1;
            else if(res == 1)l = middle+1;
            else return middle;
        }
        return l;
    }
};
