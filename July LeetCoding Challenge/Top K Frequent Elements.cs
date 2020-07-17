public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> freq = new Dictionary<int,int>();
        foreach(int num in nums)
        {
            if(!freq.ContainsKey(num))
                freq.Add(num,0);
            freq[num]++;
        }
        Tuple<int,int>[] arr = new Tuple<int,int>[freq.Count];
        int it = 0;
        foreach(KeyValuePair<int, int> entry in freq)
        {
            arr[it++] = new Tuple<int,int>(entry.Value,entry.Key);
        }
        Array.Sort(arr);
        int[] ans = new int[k];
        for(int i=0,j=arr.Length-1;i<k;i++)
        {
            ans[i] = arr[j--].Item2;
        }
        return ans;
    }
}
