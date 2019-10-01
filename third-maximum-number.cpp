class Solution {
public:
    int thirdMax(vector<int>& nums) {
        long mx1 = INT64_MIN,mx2=INT64_MIN,mx3=INT64_MIN,t1,t2;
        for(int num : nums)
        {
            if(num > mx1)
            {
                t1 = mx1;
                mx1 = num;
                t2 = mx2;
                mx2 = t1;
                mx3 = t2;
            }else if(num > mx2 && num != mx1){
                t2 = mx2;
                mx2 = num;
                mx3 = t2;
            }else if(num >= mx3 && num != mx1 && num != mx2)
                mx3 = num;
            
        }
        if(mx3 == INT64_MIN)return mx1;
        return mx3;
    }
};
