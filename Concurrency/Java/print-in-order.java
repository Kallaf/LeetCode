class Foo {
    private Semaphore secondLock;
    private Semaphore thirdLock;
    public Foo() {
        secondLock = new Semaphore(0);
        thirdLock = new Semaphore(0);
    }

    public void first(Runnable printFirst) throws InterruptedException {
        printFirst.run();
        secondLock.release();
    }

    public void second(Runnable printSecond) throws InterruptedException {
        secondLock.acquire();
        printSecond.run();
        thirdLock.release();
    }

    public void third(Runnable printThird) throws InterruptedException {
        thirdLock.acquire();
        printThird.run();
    }
}
