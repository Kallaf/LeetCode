class Solution {
private:
    vector<int> memo;
    vector<int> coinValue;
    int change(int value)
    {
        if(value == 0)return 0;
        if(value < 0)return 1000000009;
        if(memo[value] != -1)return memo[value];
        int ans = 1000000009;
        for(int i=0;i<coinValue.size();i++)
            ans = min(ans,1+change(value - coinValue[i]));
        return memo[value] = ans;
    }
public:
    int coinChange(vector<int>& coins, int amount) {
        memo.assign(amount+10,-1);
        coinValue = coins;
        int ans = change(amount);
        if(ans >= 1000000009)return -1;
        return ans;
    }
};
