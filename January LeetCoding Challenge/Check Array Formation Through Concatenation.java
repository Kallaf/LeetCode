class Solution {
    public boolean canFormArray(int[] arr, int[][] pieces) {
        int[] idx = mapToIndices(pieces);
        for(int i=0;i<arr.length;i++)
        {
            if(idx[arr[i]] == -1)return false;
            int[] piece = pieces[idx[arr[i]]];
            if(!areEqual(piece,arr,i))return false;
            i+=piece.length-1;
        }
        return true;
    }
    
    private int[] mapToIndices(int[][] pieces)
    {
        int[] idx = new int[105];
        for(int i=0;i<101;i++)idx[i] = -1;
        for(int i=0;i<pieces.length;i++)idx[pieces[i][0]] = i;
        return idx;
    }
    
    private boolean areEqual(int[] piece,int[] arr,int index)
    {
        for(int i=0;i<piece.length;i++)
            if(piece[i] != arr[index+i])
                return false;
        return true;
    }
}
