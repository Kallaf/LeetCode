class Solution {
private:
    int largestRectangleArea(vector<int>& heights) {
        int n = heights.size();
        int maxArea = 0;
        stack<pair<int,int>> st;
        for(int i=0;i<n;i++)
        {
            if(st.empty())
                st.push({heights[i],1});
            else
            {
                if(heights[i] == st.top().first)
                    st.top().second++;
                else if(heights[i] > st.top().first)
                    st.push({heights[i],1});
                else 
                {
                    int previousWidth = 0;
                    while(1)
                    {
                        previousWidth = st.top().second;
                        st.pop();
                        if(st.empty() || heights[i] > st.top().first)
                            break;
                        st.top().second += previousWidth;
                        maxArea = max(maxArea,st.top().first*st.top().second);
                    }
                    if((!st.empty()) && heights[i] == st.top().first)
                        st.top().second++;
                    else 
                        st.push({heights[i],previousWidth+1});
                }
            }
            maxArea = max(maxArea,st.top().first*st.top().second);
        }
        if(!st.empty())
        while(1)
        {
            pair<int,int> temp = st.top();
            st.pop();
            if(st.empty())
                break;
            st.top().second += temp.second;
            maxArea = max(maxArea,st.top().first*st.top().second);
        }
        return maxArea;
    }
public:
    int maximalRectangle(vector<vector<char>>& matrix) {
        int n = matrix.size();
        if(n == 0)return 0;
        int m = matrix[0].size();
        vector<vector<int>> heights(n,vector<int>(m,0));
        for(int j=0;j<m;j++)
            for(int i=0;i<n;i++)
                if(matrix[i][j] == '1')
                    heights[i][j] = i?heights[i-1][j]+1:1;
        int ans = 0;
        for(int i=0;i<n;i++)ans = max(ans,largestRectangleArea(heights[i]));
        return ans;
    }
};
