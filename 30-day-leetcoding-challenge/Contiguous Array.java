class Solution {
    public int findMaxLength(int[] nums) {
        int n = nums.length;
        if(n == 0)
            return 0;
        int sum = 0;
        HashMap<Integer,Integer> map = new HashMap<Integer,Integer>();
        map.put(0,0);
        int res = 0;
        for(int i=0;i<nums.length;i++)
        {
            sum += nums[i] == 0?-1:1;
            if(map.containsKey(sum))
                res = Math.max(res,i - map.get(sum) +1);
            else
                map.put(sum,i+1);
        }
        return res;
    }
}
