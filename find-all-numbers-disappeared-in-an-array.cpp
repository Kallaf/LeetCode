class Solution {
public:
    vector<int> findDisappearedNumbers(vector<int>& nums) {
        vector<int> res;
        for(int i=0;i<nums.size();i++)
            for(int j=0;nums[i] != i+1&&nums[i] != nums[nums[i]-1];j++)
                swap(nums[i],nums[nums[i]-1]);
        for(int i=0;i<nums.size();i++)
            if(nums[i]!=i+1)
                res.push_back(i+1);
        return res;
    }
};

auto speedup=[](){
    std::ios::sync_with_stdio(false);
    cin.tie(nullptr);
    cout.tie(nullptr);
    return nullptr;
}();
