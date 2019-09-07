class Solution {
public:
    bool searchMatrix(vector<vector<int>>& matrix, int target) {
        if(matrix.empty() || matrix[0].empty())return false;
        int i=matrix.size()-1,j=0,m = matrix[0].size()-1;
        while(0 <= i && j <= m)
        {
                if(matrix[i][j] == target)return true;
                if(matrix[i][j] < target)j++;
                else i--;
        }
        return false;
    }
};
static auto _ = []() {
    ios::sync_with_stdio(false);
    cin.tie(NULL);
    cout.tie(NULL);
    return 0;
}();
