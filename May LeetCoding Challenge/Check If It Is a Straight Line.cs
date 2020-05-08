public class Solution {
    public bool CheckStraightLine(int[][] coordinates) {
        if(coordinates.Length <= 1)return true;
        double slope = (double)(coordinates[0][1] - coordinates[1][1]) / (coordinates[0][0] - coordinates[1][0]);
        for(int i=2;i<coordinates.Length;i++)
        {
            double s = (double)(coordinates[0][1] - coordinates[i][1]) / (coordinates[0][0] - coordinates[i][0]);
            if(s != slope)
                return false;
        }
        return true;
    }
}
