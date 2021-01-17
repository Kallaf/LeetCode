class Solution {
    public int minOperations(int[] nums, int x) {
        int[] prefix = getPrefix(nums);
        int min = nums.length + 10;
        int sum = 0,n = nums.length;
        int index = binarySearch(prefix,0,n,x-sum);
        min = index > -1 ? Math.min(min,index):min;
        for(int i=n-1;i>=0 && x >= sum;i--)
        {
            sum += nums[i];
            index = binarySearch(prefix,0,i,x-sum);
            min = index > -1 ? Math.min(min,index+n-i):min;
        }
        return min > nums.length ? -1:min;
    }
    
    private int[] getPrefix(int[] nums)
    {
        int[] prefix = new int[nums.length+10];
        prefix[0] = 0;
        for(int i=0;i<nums.length;i++)
            prefix[i+1] = prefix[i] + nums[i];
        return prefix;
    }
    
    private int binarySearch(int arr[], int l, int r, int x) 
    { 
        if (r >= l) { 
            int mid = l + (r - l) / 2; 
            if (arr[mid] == x) 
                return mid; 
            if (arr[mid] > x) 
                return binarySearch(arr, l, mid - 1, x); 
            return binarySearch(arr, mid + 1, r, x); 
        }
        return -1; 
    } 
}
