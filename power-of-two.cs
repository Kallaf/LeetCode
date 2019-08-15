public class Solution {
    public bool IsPowerOfTwo(int n) {
        int len = 0;
        while(n>0){
            if((n&1) == 1)len++;
            n>>=1;
        }
        if(len == 1)return true;
        return false;
    }
}
