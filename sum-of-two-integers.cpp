class Solution {
private:
    pair<int,int> halfAdder(int a,int b)
    {
        return {a^b,a&b};
    }
    pair<int,int> fullAdder(int a,int b,int Cin)
    {
        pair<int,int> res = halfAdder(a,b);
        int AXB = res.first;
        int AB = res.second;
        res = halfAdder(AXB,Cin);
        return {res.first,AB | res.second};
    }
public:
    int getSum(int a, int b) {
        int carry = 0,sum = 0;
        for(int i=0;i<32;i++)
        {
            pair<int,int> res = fullAdder((a>>i)&1,(b>>i)&1,carry);
            sum |= res.first<<i;
            carry = res.second;
        }
        return sum;
    }
};
