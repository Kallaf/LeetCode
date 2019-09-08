class Solution {
public:
    void reverseString(vector<char>& s) {
        int n = s.size();
        for(int i=0;i<(n+1)/2;i++)
            swap(s[i],s[n-i-1]);
        
    }
};

static auto _ = []() {
    ios::sync_with_stdio(false);
    cin.tie(NULL);
    cout.tie(NULL);
    return 0;
}();
