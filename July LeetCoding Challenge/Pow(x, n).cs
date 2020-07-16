public class Solution {
    private double Pow(double x, uint n){
        double res = 1;
        while (n > 0) 
        { 
            if ((n & 1) == 1) 
                res = res*x; 

            n = n>>1;
            x = x*x; 
        } 
        return res; 
    }
    
    private double negPow(double x, uint n){
        double res = 1;
        while (n > 0) 
        { 
            if ((n & 1) == 1) 
                res = res*(1/x); 

            n = n>>1;
            x = x*x; 
        } 
        return res; 
    }
    
    public double MyPow(double x, int n) {
        if(x == 0)
            return 0;
        if(n<0)
            return negPow(x,(uint)-n);
        return Pow(x,(uint)n);
    }
}
