public class Solution {
    public int CountPrimes(int n) {
        if(n==0)return 0;
        int count = 0;
        for(int x=2;x<n;x++)
        {
            bool isPrime = true;
            for(int i=2;i<=Math.Sqrt(x);i++)if(x%i == 0){
                isPrime = false;
                break;
            }
            if(isPrime)count++;
        }
        return count;
    }
}
