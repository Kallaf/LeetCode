class Solution {
public:
    int maxProfit(vector<int>& prices) {
        if(prices.empty())return 0;
        int ans = 0;
        int last_min = prices[0];
        for(int i=1;i<prices.size();i++)
            if(prices[i] > last_min)
                ans = max(ans,prices[i] - last_min);
            else
                last_min = prices[i];
        return ans;
    }
};
