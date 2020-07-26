public class Solution {
    public int AddDigits(int num) {
        if(num < 10)
            return num;
        int sum = 0;
        while(num > 0)
        {
            sum += num%10;
            num /= 10;
        }
        return AddDigits(sum);
    }
}
