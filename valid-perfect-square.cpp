class Solution {
public:
    bool isPerfectSquare(int num) {
        int sq = sqrt(num);
        return num == sq*sq;
    }
};
