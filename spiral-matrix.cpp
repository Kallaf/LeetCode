class Solution {
private:
    vector<pair<int,int>> directions;
    int curr;
    void turnRight()
    {
       curr++;
       curr%=4;
    }
    
public:
    Solution() 
    { 
        directions.push_back(make_pair(0,1));
        directions.push_back(make_pair(1,0));
        directions.push_back(make_pair(0,-1));
        directions.push_back(make_pair(-1,0));
        curr = 0;
    }
    vector<int> spiralOrder(vector<vector<int>>& matrix) {
        vector<int> ans;
        if(matrix.empty())return ans;
        int n = matrix[0].size(),m = matrix.size();
        vector<bool> rows(n,false);
        vector<vector<bool>> visited(m,rows);
        pair<int,int> currCell = make_pair(0,0);
        int countVisited = 0,mustBeVisited = n*m;
        
        if(mustBeVisited)
        {
            ans.push_back(matrix[currCell.first][currCell.second]);
            visited[currCell.first][currCell.second] = true;
            countVisited++;
        }
        while(countVisited != mustBeVisited)
        {
            pair<int,int> nextCell = make_pair(currCell.first+directions[curr].first,currCell.second+directions[curr].second);
            if(nextCell.first == m || nextCell.second == n || nextCell.first == -1 || nextCell.second == -1 || visited[nextCell.first][nextCell.second])
                turnRight();
            else
            {
                currCell = nextCell;
                ans.push_back(matrix[currCell.first][currCell.second]);
                visited[currCell.first][currCell.second] = true;
                countVisited++;
            }
        }
        return ans;
    }
};
