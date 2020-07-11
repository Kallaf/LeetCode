public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        IList<IList<int>> res = new List<IList<int>>();
        int n = 1 << nums.Length;
        for(int i=0;i<n;i++)
        {
            IList<int> row = new List<int>();
            for(int j = i,k=0;j>0;j>>=1,k++)
            {
                if((j&1) == 1)
                    row.Add(nums[k]);
            }
            res.Add(row);
        }
        return res;
    }
}
