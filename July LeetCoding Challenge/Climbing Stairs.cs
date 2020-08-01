public class Solution {
    public int ClimbStairs(int n) {
        int prevprev = 0,prev = 1,curr=0;
        for(int i=1;i<=n;i++)
        {
            curr = prev + prevprev;
            prevprev = prev;
            prev = curr;
        }
        return curr;
    }
}
