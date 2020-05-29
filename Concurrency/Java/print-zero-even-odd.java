class ZeroEvenOdd {
    private int n;
    private CountDownLatch zero;
    private CountDownLatch odd;
    private CountDownLatch even;
    
    public ZeroEvenOdd(int n) {
        this.n = n;
        this.zero = new CountDownLatch(0);
        this.odd = new CountDownLatch(1);
        this.even = new CountDownLatch(3);
    }

    // printNumber.accept(x) outputs "x", where x is an integer.
    public void zero(IntConsumer printNumber) throws InterruptedException {
        for(int i=0;i<n;i++)
        {
            zero.await();
            printNumber.accept(0);
            zero = new CountDownLatch(1);
            odd.countDown();
            even.countDown();
        } 
    }

    public void even(IntConsumer printNumber) throws InterruptedException {
        for(int i=2;i<=n;i+=2)
        {
            even.await();
            printNumber.accept(i);
            even = new CountDownLatch(3);
            zero.countDown();
            odd.countDown();
        }
    }

    public void odd(IntConsumer printNumber) throws InterruptedException {
        for(int i=1;i<=n;i+=2)
        {
            odd.await();
            printNumber.accept(i);
            odd = new CountDownLatch(3);
            zero.countDown();
            even.countDown();
        }
    }
}
