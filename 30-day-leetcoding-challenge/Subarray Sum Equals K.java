class Solution {
    public int subarraySum(int[] nums, int k) {
        int[] prefix = new int[nums.length];
        prefix[0] = nums[0];
        for(int i=1;i<nums.length;i++)
            prefix[i] = prefix[i-1] + nums[i];
        int res = 0;
        HashMap<Integer,Integer> map=new HashMap<>();
        for(int i=0;i<nums.length;i++)
        {
            if(prefix[i]==k)res++;
            int diff=prefix[i]-k;
            if(map.containsKey(diff))res+=map.get(diff);
            if(map.containsKey(prefix[i]))map.put(prefix[i],map.get(prefix[i])+1);
            else map.put(prefix[i],1);
        }
        return res;
    }
}
