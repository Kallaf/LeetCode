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
    
    vector<vector<int>> generateMatrix(int n) {
        vector<int> row(n);
        vector<vector<int>> matrix(n,row);
        vector<bool> rows(n,false);
        vector<vector<bool>> visited(n,rows);
        pair<int,int> currCell = make_pair(0,0);
        int countVisited = 0,n2 = n*n;
        if(n2)
        {
            matrix[currCell.first][currCell.second] = ++countVisited;
            visited[currCell.first][currCell.second] = true;
        }
        while(countVisited != n2)
        {
            pair<int,int> nextCell = make_pair(currCell.first+directions[curr].first,currCell.second+directions[curr].second);
            if(nextCell.first == n || nextCell.second == n || nextCell.first == -1 || nextCell.second == -1 || visited[nextCell.first][nextCell.second])
                turnRight();
            else
            {
                currCell = nextCell;
                matrix[currCell.first][currCell.second] = ++countVisited;
                visited[currCell.first][currCell.second] = true;
            }
        }
        return matrix;
    }
};
