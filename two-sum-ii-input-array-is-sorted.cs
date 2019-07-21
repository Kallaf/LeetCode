public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        for(int i=0;i<numbers.Length-1;i++)
        {
            if(numbers[i] > target)break;
            for(int j=i+1;j<numbers.Length;j++)
            {
                if(numbers[i]+numbers[j]>target)break;
                if(numbers[i]+numbers[j]==target)return new int[] {i+1,j+1};
            }
        }
        return null;
    }
}
