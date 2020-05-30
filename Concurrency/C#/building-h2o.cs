using System.Threading;

public class H2O {

    private  Barrier water;
    private Semaphore oxygen;
    private Semaphore hydrogen;
    public H2O() {
        this.water = new Barrier(3);
        this.oxygen = new Semaphore(1, 1);
        this.hydrogen = new Semaphore(2, 2);
    }

    public void Hydrogen(Action releaseHydrogen) {
        hydrogen.WaitOne();
        water.SignalAndWait();
        // releaseHydrogen() outputs "H". Do not change or remove this line.
        releaseHydrogen();
        hydrogen.Release();
    }

    public void Oxygen(Action releaseOxygen) {
        oxygen.WaitOne();
        water.SignalAndWait();
        // releaseOxygen() outputs "O". Do not change or remove this line.
        releaseOxygen();
        oxygen.Release();
    }
}
