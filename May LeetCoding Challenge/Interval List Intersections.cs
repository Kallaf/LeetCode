public class Solution {
    public int[][] IntervalIntersection(int[][] A, int[][] B) {
        List<int[]> res = new List<int[]>();
        for(int i=0,j=0;i<A.Length&&j<B.Length;)
        {
            int[] arr = new int[2];
            arr[0] = Math.Max(A[i][0],B[j][0]);
            arr[1] = Math.Min(A[i][1],B[j][1]);
            if(arr[0] <= arr[1])res.Add(arr);
            if(A[i][1] < B[j][1])i++;
            else if(A[i][1] > B[j][1])j++;
            else {
                i++;
                j++;
            }
        }
        return res.ToArray();
    }
}
