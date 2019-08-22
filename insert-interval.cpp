class Solution {
public:
    vector<vector<int>> insert(vector<vector<int>>& intervals, vector<int>& newInterval) {
        intervals.push_back(newInterval);
        sort(intervals.begin(),intervals.end());
        vector<vector<int>> newIntervals;
        if(intervals.empty())return newIntervals;
        int index = 0;
        newIntervals.push_back(intervals[0]);
        for(int i=1;i<intervals.size();i++)
        {
            if(intervals[i][0] <= newIntervals[index][1])
                newIntervals[index][1] = max(intervals[i][1],newIntervals[index][1]);
            else{
                newIntervals.push_back(intervals[i]);
                index++;
            }
        }
        return newIntervals;
    }
};
