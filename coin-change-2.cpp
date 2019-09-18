class Solution {
private:
    vector<vector<int>> memo;

    int ways(int type,int value,vector<int>& coins)
    {
        if(value == 0)return 1;
        if(value < 0)return 0;
        if(type == coins.size())return 0;
        if(memo[type][value] != -1)return memo[type][value];
        return memo[type][value] = ways(type + 1, value,coins) + // if we ignore this coin type,
    ways(type, value - coins[type],coins); // plus if we use this coin type
    }

public:
    int change(int amount, vector<int>& coins) {
        memo.resize(coins.size()+1);
        for (int i = 0; i <= coins.size(); ++i)
            memo[i].assign(amount+3,-1);
        return ways(0,amount,coins);    
    }
};
