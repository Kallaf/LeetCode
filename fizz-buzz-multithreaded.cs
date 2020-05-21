using System.Threading;
public class FizzBuzz {
    private int n;
    private EventWaitHandle fizz;
    private EventWaitHandle buzz;
    private EventWaitHandle fizzbuzz;
    private EventWaitHandle number;
    private int it = 1;
    public FizzBuzz(int n) {
        this.n = n;
        this.fizz = new AutoResetEvent(initialState: false);
        this.buzz = new AutoResetEvent(initialState: false);
        this.fizzbuzz = new AutoResetEvent(initialState: false);
        this.number = new AutoResetEvent(initialState: true);
    }

    // printFizz() outputs "fizz".
    public void Fizz(Action printFizz) {
        while(true)
        {
            fizz.WaitOne();
            if(it>n)break;
            printFizz();
            number.Set();
        }
    }

    // printBuzzz() outputs "buzz".
    public void Buzz(Action printBuzz) {
        while(true)
        {
            buzz.WaitOne();
            if(it>n)break;
            printBuzz();
            number.Set();   
        }
    }

    // printFizzBuzz() outputs "fizzbuzz".
    public void Fizzbuzz(Action printFizzBuzz) {
        while(true)
        {
            fizzbuzz.WaitOne();
            if(it>n)break;
            printFizzBuzz();
            number.Set();   
        }
    }

    // printNumber(x) outputs "x", where x is an integer.
    public void Number(Action<int> printNumber) {
        for(it=1;it<=n;it++)
        {
            if(it%3 == 0 && it%5 == 0)
            {
                fizzbuzz.Set();
                number.WaitOne();
            }else if(it%3 == 0)
            {
                fizz.Set();
                number.WaitOne();
            }else if(it%5 == 0)
            {
                buzz.Set();
                number.WaitOne();
            }else{
                printNumber(it);   
            }
        }
        fizz.Set();
        buzz.Set();
        fizzbuzz.Set();
    }
}
