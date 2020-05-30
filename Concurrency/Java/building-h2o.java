class H2O {

    private Semaphore h2;
    private Semaphore o;
    private CyclicBarrier barrier;
    
    public H2O() {
        h2 = new Semaphore(2);
        o = new Semaphore(1);
        barrier = new CyclicBarrier(3);
    }

    public void hydrogen(Runnable releaseHydrogen) throws InterruptedException {
        h2.acquire();
        try{
            barrier.await();    
        }catch(BrokenBarrierException ex)
        {
            System.err.println(ex);
        }
        releaseHydrogen.run();
        h2.release();
    }

    public void oxygen(Runnable releaseOxygen) throws InterruptedException {
        o.acquire();
        try{
            barrier.await();    
        }catch(BrokenBarrierException ex)
        {
            System.err.println(ex);
        }
        releaseOxygen.run();
        o.release();
    }
}
