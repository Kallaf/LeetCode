class Solution {
private:
    static bool compare (vector<int> p1,vector<int> p2)
    {
        int d1 = p1[0] * p1[0] + p1[1] * p1[1];
        int d2 = p2[0] * p2[0] + p2[1] * p2[1];
        return d1<d2; 
    }
public:
    vector<vector<int>> kClosest(vector<vector<int>>& points, int K) {
        std::nth_element(points.begin(), points.begin()+K, points.end(),compare);
        vector<vector<int>>::const_iterator first = points.begin();
        vector<vector<int>>::const_iterator last = points.begin() + K;
        vector<vector<int>> subVec(first, last);
        return subVec;
    }
};
