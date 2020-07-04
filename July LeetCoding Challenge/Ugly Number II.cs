public class Solution {
    public int NthUglyNumber(int n) {
        SortedSet<long> pq = new SortedSet<long>();
        pq.Add(1);
        for(int i=1;i<n;i++)
        {
            pq.Add(pq.Min*(long)2);
            pq.Add(pq.Min*(long)3);
            pq.Add(pq.Min*(long)5);
            pq.Remove(pq.Min);
        }
        return (int)pq.Min;
    }
}
