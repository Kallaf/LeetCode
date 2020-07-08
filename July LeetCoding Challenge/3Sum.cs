public class Solution {
    private void AddList(IList<IList<int>> list,int a,int b,int c)
    {
        IList<int> l = new List<int>();
        l.Add(a);l.Add(b);l.Add(c);
        list.Add(l);
    }
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        HashSet<int> cnt = new HashSet<int>();
        foreach(int num in nums)
        {
            if(!cnt.Contains(num))
               cnt.Add(num);
        }
        
        IList<IList<int>> ret = new List<IList<int>>();
        int i;
        for(i=0;i<nums.Length && nums[i] < 0;i++)
        {
            if(i==0 || nums[i] != nums[i-1])
            {
                for(int j=i+1;j<nums.Length && nums[j] <= 0;j++)
                {
                    if(j == i+1 || nums[j] != nums[j-1])
                    {
                        int x = -1 * (nums[i]+nums[j]);
                        if(cnt.Contains(x))
                        {
                            AddList(ret,nums[i],nums[j],x);
                        }
                    }
                }
            }
        }
        
        int cnt0 = 0;
        for(;i<nums.Length && nums[i] == 0;i++)cnt0++;
        if(cnt0 >=3)AddList(ret,0,0,0);
        
        for(;i<nums.Length;i++)
        {
            if(i==0 || nums[i] != nums[i-1])
            {
                for(int j=i+1;j<nums.Length;j++)
                {
                    if(j == i+1 || nums[j] != nums[j-1])
                    {
                        int x = -1 * (nums[i]+nums[j]);
                        if(cnt.Contains(x))
                        {
                            AddList(ret,nums[i],nums[j],x);
                        }
                    }
                }
            }
        }
        
        return ret;
    }
}
