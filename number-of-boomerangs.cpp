class Solution {
private:
    int distance(vector<int> point1,vector<int> point2)
    {
        int dx = point1[0] - point2[0];
        int dy = point1[1] - point2[1];
        return dx*dx + dy*dy;
    }
public:
    int numberOfBoomerangs(vector<vector<int>>& points) {
        int res = 0;
        for(int i=0;i<points.size();i++)
        {
            map<int,int> cnt;
            for(int j=0;j<points.size();j++)
            {
                if(i!=j)
                    cnt[distance(points[i],points[j])]++;   
            }
            for(pair<int,int> c:cnt)
                res += c.second * (c.second-1);
        }
        return res;
    }
};
