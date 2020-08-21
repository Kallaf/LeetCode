class Solution {
    public int[] sortArrayByParity(int[] A) {
        int[] ans = new int[A.length];
        int i=0,j=A.length-1;
        for(int k=0;k<A.length;k++)
        {
            if(A[k] % 2 == 0)
                ans[i++] = A[k];
            else
                ans[j--] = A[k];
        }
        return ans;
    }
}
