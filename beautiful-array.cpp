class Solution {
private:
        map<int,vector<int>> dp;
        vector<int> f(int n)
        {
            if(dp.count(n))return dp[n];
            vector<int> ans(n);
            if(n == 1)
                ans[0] = 1;
            else{
                int t = 0;
                vector<int> odds = f((n+1)/2);
                for(auto it = odds.begin();it!=odds.end();it++)
                    ans[t++] = 2*(*it) - 1;
                
                vector<int> evens = f(n/2);
                for(auto it = evens.begin();it!=evens.end();it++)
                    ans[t++] = 2*(*it);
            }
            dp[n] = ans;
            return ans;
        }
public:
    vector<int> beautifulArray(int n) {
        return f(n);
    }
};

static auto _ = [](){
    ios::sync_with_stdio(false);
    cin.tie(NULL);
    cout.tie(NULL);
};
