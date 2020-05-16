using System.Threading;  
public class FooBar {
    private int n;
    private EventWaitHandle waitFirst;
    private EventWaitHandle waitSecond;
    
    public FooBar(int n) {
        this.n = n;
        this.waitFirst = new AutoResetEvent(initialState: false);
        this.waitSecond = new AutoResetEvent(initialState: false);
    }

    public void Foo(Action printFoo) {
        for (int i = 0; i < n; i++) {
        	printFoo();
            waitFirst.Set();
            waitSecond.WaitOne();
        }
    }

    public void Bar(Action printBar) {
        for (int i = 0; i < n; i++) {
            waitFirst.WaitOne();
            printBar();
            waitSecond.Set();
        }
    }
}
