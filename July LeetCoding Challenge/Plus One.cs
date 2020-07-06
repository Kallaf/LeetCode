public class Solution {
    public int[] PlusOne(int[] digits) {
        int n = digits.Length;
        for(int i=n-1;i>=0;i--)
        {
            if(digits[i] + 1 == 10)
                digits[i] = 0;
            else
            {
                digits[i]++;
                return digits;
            }
        }
        int[] res = new int[n+1];
        Array.Fill(res,0);
        res[0] = 1;
        return res;
    }
}
