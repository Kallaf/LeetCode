public class Solution {
    private HashSet<int> all;
    public Solution()
    {
        all = new HashSet<int>();
        long x = 1;
        while(x <= Int32.MaxValue)
        {
            all.Add((int)x);
            x <<= 2;
        }
    }
    public bool IsPowerOfFour(int num) {
        return all.Contains(num);
    }
}
