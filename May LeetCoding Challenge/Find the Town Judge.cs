public class Solution {
    public int FindJudge(int N, int[][] trust) {
        int[] countIn = new int[N+1];
        int[] countOut = new int[N+1];
        foreach(int[] pair in trust)
        {
            countOut[pair[0]]++;
            countIn[pair[1]]++;
        }
        for(int i=1;i<=N;i++)if(countOut[i] == 0 && countIn[i] == N-1)return i;
        return -1;
    }
}
