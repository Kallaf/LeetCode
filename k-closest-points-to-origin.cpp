class Compare {
public:
        bool operator()(const vector<int>& point1,const vector<int>& point2){
                return point1[0]*point1[0]+point1[1]*point1[1] < point2[0]*point2[0]+point2[1]*point2[1];
        }
};

class Solution {
public:
    vector<vector<int>> kClosest(vector<vector<int>>& points, int K) {
        nth_element(points.begin(),points.begin()+K,points.end(),Compare());
        
        vector<vector<int>> ans;
        for(int i=0;i<K;i++)
                ans.push_back(points[i]);
        return ans;
    }
};
