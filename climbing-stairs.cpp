class Solution {
public:
    int climbStairs(int n) {
        if(n == 1)return 1;
        if(n == 2)return 2;
        int before_previous=1,previous=2,current;
        for(int i=3;i<=n;i++)
        {
            current = previous + before_previous;
            before_previous = previous;
            previous = current; 
        }
        return current;
    }
};
