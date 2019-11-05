class Solution {
public:
    vector<int> constructRectangle(int area) {
        int root = sqrt(area);
        for(;area%root;root--); 
        return vector{area/root,root};
    }
};
