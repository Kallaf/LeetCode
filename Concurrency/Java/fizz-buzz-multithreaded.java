class FizzBuzz {
    private int n;
    private Semaphore fizz;
    private Semaphore buzz;
    private Semaphore fizzbuzz;
    private Semaphore number;
    private int it = 1;

    public FizzBuzz(int n) {
        this.n = n;
        this.fizz = new Semaphore(0);
        this.buzz = new Semaphore(0);
        this.fizzbuzz = new Semaphore(0);
        this.number = new Semaphore(0);
    }

    // printFizz.run() outputs "fizz".
    public void fizz(Runnable printFizz) throws InterruptedException {
        while(true)
        {
            fizz.acquire();
            if(it>n)break;
            printFizz.run();
            number.release();
        }
    }

    // printBuzz.run() outputs "buzz".
    public void buzz(Runnable printBuzz) throws InterruptedException {
        while(true)
        {
            buzz.acquire();
            if(it>n)break;
            printBuzz.run();
            number.release();   
        }
    }

    // printFizzBuzz.run() outputs "fizzbuzz".
    public void fizzbuzz(Runnable printFizzBuzz) throws InterruptedException {
        while(true)
        {
            fizzbuzz.acquire();
            if(it>n)break;
            printFizzBuzz.run();
            number.release();   
        }
    }

    // printNumber.accept(x) outputs "x", where x is an integer.
    public void number(IntConsumer printNumber) throws InterruptedException {
        for(it=1;it<=n;it++)
        {
            if(it%3 == 0 && it%5 == 0)
            {
                fizzbuzz.release();
                number.acquire();
            }else if(it%3 == 0)
            {
                fizz.release();
                number.acquire();
            }else if(it%5 == 0)
            {
                buzz.release();
                number.acquire();
            }else{
                printNumber.accept(it);   
            }
        }
        fizz.release();
        buzz.release();
        fizzbuzz.release();
    }
}
