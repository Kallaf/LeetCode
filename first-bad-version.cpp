// Forward declaration of isBadVersion API.
bool isBadVersion(int version);

class Solution {
public:
    int firstBadVersion(int n) {
        long long int l = 1,r=n;
        int first_bad;
        while(l<=r)
        {
            long long int mid = (l+r)/2;
            if(isBadVersion(mid)){first_bad = (int) mid;r = mid-1;}
            else l = mid+1;
        }
        return first_bad;
    }
};

