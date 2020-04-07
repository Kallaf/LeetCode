class Solution {
    public int countElements(int[] arr) {
        Arrays.sort(arr);
        int cnt = 1,res = 0;
        for(int i=1;i<arr.length;i++)
        {
            if(arr[i] == arr[i-1])
                cnt++;
            else {
                if(arr[i] == arr[i-1] + 1)
                    res += cnt;
                cnt = 1;
            }
        }
        return res;
    }
}
