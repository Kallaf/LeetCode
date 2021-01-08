class Solution {
    public int findKthPositive(int[] arr, int k) {
        int l = 0,h = arr.length-1;
        while(l <= h)
        {
            int mid = l + (h-l)/2;
            if(arr[mid]-(mid+1) < k) l = mid+1;
            else h = mid-1;
        }
        return l+k;
    }
}
