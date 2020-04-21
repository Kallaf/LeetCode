class Solution {
    public int leftMostColumnWithOne(BinaryMatrix binaryMatrix) {
        List<Integer> dimensions = binaryMatrix.dimensions();
        int n = dimensions.get(0), m = dimensions.get(1);
        
        int min = m;
        for(int i=0,j=m-1;i<n && j>=0;)
        {
            if(binaryMatrix.get(i,j) == 0)
                i++;
            else
                min = j--;
        }
        if(min == m)return -1;
        return min;
    }
}
