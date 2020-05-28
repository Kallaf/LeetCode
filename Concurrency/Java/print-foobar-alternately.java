class FooBar {
    private int n;
    private Semaphore waitFirst;
    private Semaphore waitSecond;
    
    public FooBar(int n) {
        this.n = n;
        this.waitFirst = new Semaphore(0);
        this.waitSecond = new Semaphore(0);
    }

    public void foo(Runnable printFoo) throws InterruptedException {
        for (int i = 0; i < n; i++) {
            // printFoo.run() outputs "foo". Do not change or remove this line.
            printFoo.run();
            waitFirst.release();
            waitSecond.acquire();
        }
    }

    public void bar(Runnable printBar) throws InterruptedException {
        for (int i = 0; i < n; i++) {
          waitFirst.acquire();
          // printBar.run() outputs "bar". Do not change or remove this line.
          printBar.run();
          waitSecond.release();
        }
    }
}
