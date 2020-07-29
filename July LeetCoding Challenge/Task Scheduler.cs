public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        int[] freq = new int[26];
        foreach(char c in tasks)
            freq[c-'A']++;
        Array.Sort(freq);
        int idle = (freq[25]-1) * n;
        for(int i=0;i<25;i++)
            idle -= Math.Min((freq[25]-1),freq[i]);
        idle = Math.Max(idle,0);
        return tasks.Length + idle;
    }
}
