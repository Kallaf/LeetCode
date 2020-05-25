class DiningPhilosophers {
    private Semaphore[] fork;
    private Semaphore mutex;
    public DiningPhilosophers() {
        this.fork = new Semaphore[5];
        this.mutex = new Semaphore(1, true);
        for(int i=0;i<5;i++)
            this.fork[i] = new Semaphore(1, true);
    }

    // call the run() method of any runnable to execute its code
    public void wantsToEat(int philosopher,
                           Runnable pickLeftFork,
                           Runnable pickRightFork,
                           Runnable eat,
                           Runnable putLeftFork,
                           Runnable putRightFork) throws InterruptedException {
        
        mutex.acquire();
        
        fork[philosopher].acquire();
        fork[(philosopher+1)%5].acquire();
        
        mutex.release();
        
        pickLeftFork.run();
        pickRightFork.run();
        eat.run();
        putLeftFork.run();
        putRightFork.run();
        
        fork[philosopher].release();
        fork[(philosopher+1)%5].release();
    }
}
