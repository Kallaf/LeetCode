class Solution {
public:
    int findRadius(vector<int>& houses, vector<int>& heaters) {
        	if(heaters.empty())return 0;
            sort(heaters.begin(),heaters.end());
            int res = 0;
            for(int house:houses)
            {
                int distance;
                vector<int>::iterator it = lower_bound(heaters.begin(),heaters.end(),house);
                if(it == heaters.end())
                {
                    it--;
                    distance = house - (*it);
                }else{
                    distance = (*it) - house;
                    if (it != heaters.begin()) {
                        it--;
                        distance = min(house - (*it),distance);
                    }    
                    
                    
                }
                
                res = max(res,distance);
            }
            return res;
    }
};
