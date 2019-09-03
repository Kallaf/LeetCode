class Solution {
public:
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
                    while(heights[i] < st.top().first)
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
        while(!st.empty())
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
};
