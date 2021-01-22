class Solution {
    public int findKthLargest(int[] nums, int k) {
        return findKthElementByQuickSelect(nums,0,nums.length-1,k-1);
    }
    
    public int findKthElementByQuickSelect(int[] arr, int left, int right, int k) {
        if (0 <= k && k <= right - left + 1) {
            int pos = randomPartition(arr, left, right);
            if (pos - left == k) {
                return arr[pos];
            }
            if (pos - left > k) {
                return findKthElementByQuickSelect(arr, left, pos - 1, k);
            }
            return findKthElementByQuickSelect(arr, pos + 1,
              right, k - pos + left - 1);
        }
        return 0;
    }
    
    public int randomPartition(int arr[], int left, int right) {
        int n = right - left + 1;
        int pivot = (int) (Math.random()) * n;
        swap(arr, left + pivot, right);
        return partition(arr, left, right);
    }
    
    public int partition(int[] arr, int left, int right) {
        int pivot = arr[right], i = left;
        for (int j = left; j <= right - 1; j++) {
            if (arr[j] >= pivot) {
                swap(arr, i, j);
                i++;
            }
        }
        swap(arr, i, right);
        return i;
    }

    public void swap(int[] arr, int n1, int n2) {
        int temp = arr[n2];
        arr[n2] = arr[n1];
        arr[n1] = temp;
    }
}
