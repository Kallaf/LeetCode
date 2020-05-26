public class Solution {
    public int FindMaxLength(int[] nums) {
        int n = nums.Length;
        if(n == 0)return 0;
        int sum = 0;
        Dictionary<int,int> map = new Dictionary<int,int>();
        map.Add(0,0);
        int res = 0;
        for(int i=0;i<n;i++)
        {
            sum += nums[i] == 0?-1:1;
            if(map.ContainsKey(sum))
                res = Math.Max(res,i - map[sum] +1);
            else
                map.Add(sum,i+1);
        }
        return res;
    }
}
