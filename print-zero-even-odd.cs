using System.Threading;
public class ZeroEvenOdd {
    private int n;
    private CountdownEvent zero;
    private CountdownEvent odd;
    private CountdownEvent even;
    
    public ZeroEvenOdd(int n) {
        this.n = n;
        this.zero = new CountdownEvent(0);
        this.odd = new CountdownEvent(1);
        this.even = new CountdownEvent(3);
    }

    // printNumber(x) outputs "x", where x is an integer.
    public void Zero(Action<int> printNumber) {
        for(int i=0;i<n;i++)
        {
            zero.Wait();
            printNumber(0);
            zero.Reset(1);
            odd.Signal();
            even.Signal();
        } 
    }

    public void Even(Action<int> printNumber) {
        for(int i=2;i<=n;i+=2)
        {
            even.Wait();
            printNumber(i);
            even.Reset(3);
            zero.Signal();
            odd.Signal();
        }
    }

    public void Odd(Action<int> printNumber) {
        for(int i=1;i<=n;i+=2)
        {
            odd.Wait();
            printNumber(i);
            odd.Reset(3);
            zero.Signal();
            even.Signal();
        }
    }
}
