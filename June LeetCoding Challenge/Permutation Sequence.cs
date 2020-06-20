public class Solution {
    private int[] fact;
    public Solution()
    {
        fact = new int[10];
        fact[0] = fact[1] = 1;
        for(int i=2;i<10;i++)
            fact[i] = fact[i-1] * i;
    }
    
    private string GetPermutation(List<int> nums,int k)
    {
        int n = nums.Count;
        if(n == 0)return "";
        int i = k/fact[n-1];
        string ans = nums[i].ToString();
        nums.RemoveAt(i);
        return ans + GetPermutation(nums,k%fact[n-1]);
    }
    
    public string GetPermutation(int n, int k) {
        List<int> nums = new List<int>();
        for(int i=1;i<=n;i++)
            nums.Add(i);
        return GetPermutation(nums,k-1);
    }
}
