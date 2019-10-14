class Solution {
public:
    int minMoves(vector<int>& nums) {
        int mn = INT32_MAX;   
        for(int num:nums)mn = min(mn,num);
        int res = 0;
        for(int num:nums)res += (num-mn);
        return res;
    }
};
static int fast_io = []() {
    std::ios::sync_with_stdio(false);
    cin.tie(nullptr);
    return 0;
}();
