class Solution {
private:
    vector<int> dp;
public:
    Solution()
    {
        dp.assign(32,-1);
    }
    int fib(int N) {
        if(N < 2)return N;
        if(dp[N] != -1)return dp[N];
        return dp[N] = fib(N-1) + fib(N-2);
    }
};
