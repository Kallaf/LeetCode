class Solution {
private:
    int memo[102][102];
    int n;
    int minCost(vector<vector<int>>& costs,int idx,int x,int y)
    {
        if(idx == 2*n)return 0;
        int& res = memo[idx][x];
        if(res != -1)return res;
        res = INT32_MAX;
        if(x > 0)res = costs[idx][0] + minCost(costs,idx+1,x-1,y);
        if(y > 0)res = min(res,costs[idx][1] + minCost(costs,idx+1,x,y-1));
        return res;
    }
    
public:
    int twoCitySchedCost(vector<vector<int>>& costs) {
        n = (int)costs.size()/2;
        memset(memo,-1,sizeof(memo));
        return minCost(costs,0,n,n);
    }
};
