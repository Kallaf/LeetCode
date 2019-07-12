class Solution {
public:
    vector<vector<int>> generate(int numRows) {
        vector<vector<int>> pascal_triangle;
        for(int i=1;i<=numRows;i++)
        {
            vector<int> temp(i);
            temp[0] = 1;
            temp[i-1] = 1;
            pascal_triangle.push_back(temp);
        }
        for(int i=2;i<numRows;i++)
            for(int j=1;j<i;j++)
                pascal_triangle[i][j] = pascal_triangle[i-1][j-1] + pascal_triangle[i-1][j];
        return pascal_triangle;
    }
};
