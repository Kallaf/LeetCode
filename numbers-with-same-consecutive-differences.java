class Solution {
    private void solve(int N,int x,int K,int curr,List<Integer> list)
    {
        curr *= 10;
        curr += x;
        if(N == 1)
        {
            list.add(curr);
            return;
        }
        if(x - K > -1 && K != 0)
           solve(N-1,x-K,K,curr,list);
        if(x + K < 10)
           solve(N-1,x+K,K,curr,list);
    }
    public int[] numsSameConsecDiff(int N, int K) {
        if(N == 1)
            return new int[]{0,1,2,3,4,5,6,7,8,9};
        List<Integer> list = new ArrayList<Integer>();
        for(int x=1;x<=9;x++)
            solve(N,x,K,0,list);
        int[] ans = new int[list.size()];
        for(int i=0;i<ans.length;i++)
            ans[i] = list.get(i);
        return ans;
    }
}
