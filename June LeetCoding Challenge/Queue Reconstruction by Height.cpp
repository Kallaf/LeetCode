class Solution {
public:
    vector<vector<int>> reconstructQueue(vector<vector<int>>& people) {
        sort(people.begin(),people.end());
        set<int> available_positions;
        for(int i=0;i<people.size();i++)
            available_positions.insert(i);
        vector<vector<int>> ans(people.size());
        for(int i=0,cnt;i<people.size();i++,cnt++)
        {
            if(i == 0 || people[i][0] != people[i-1][0])
                cnt = 0;
            std::set<int>::iterator it = available_positions.begin();
            std::advance(it, people[i][1] - cnt);
            int x = *it;
            available_positions.erase(it);
            ans[x] = people[i];
        }
        return ans;
    }
};
