class NumArray {
private:
    vector<int> sums;
public:
    NumArray(vector<int>& nums) {
        sums.assign(nums.size()+1,0);
        for(int i=0;i<nums.size();i++)
            sums[i+1] = sums[i]+nums[i];
    }
    
    int sumRange(int i, int j) {
        return sums[j+1] - sums[i];
    }
};

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray* obj = new NumArray(nums);
 * int param_1 = obj->sumRange(i,j);
 */
