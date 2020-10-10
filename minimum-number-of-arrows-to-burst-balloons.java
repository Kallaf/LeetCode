class Solution {
    public int findMinArrowShots(int[][] points) {
        if(points.length == 0)
            return 0;
        
        //Sort the points by their ends asendingly
        Arrays.sort(
            points, 
            Comparator.comparingInt(point -> point[1])
        );
        
        int arrowShotsCount = 1;
        int lastArrowShotLocation = points[0][1];
        
        for(int i=1;i<points.length;i++)
        {
            if(points[i][0] > lastArrowShotLocation)
            {
                lastArrowShotLocation = points[i][1];
                arrowShotsCount++;
            }
        }
        return arrowShotsCount;
    }
}
