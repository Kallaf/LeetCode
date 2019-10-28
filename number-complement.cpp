class Solution {

public:
    int findComplement(int num) {
        int mask = num;
        for(int i=1;i<=16;i*=2)
            mask |= mask >> i;
        return num^mask;
    }
};
