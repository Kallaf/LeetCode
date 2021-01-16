class Solution {
    public int numRescueBoats(int[] people, int limit) {
        int count = 0;
        Arrays.sort(people);
        for(int i=0,j=people.length-1;i<=j;j--,count++)
        {
            int weight = people[j];
            if(weight + people[i] <= limit)
                weight += people[i++];
        }
        return count;
    }
}
