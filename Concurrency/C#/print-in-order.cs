using System.Threading;

public class Foo {

    private CountdownEvent first;
    private CountdownEvent second;

    public Foo() {
        first = new CountdownEvent(1);
        second = new CountdownEvent(1);
    }

    public void First(Action printFirst) {
        
        // printFirst() outputs "first". Do not change or remove this line.
        printFirst();
        first.Signal();
    }

    public void Second(Action printSecond) {
        
        first.Wait();
        // printSecond() outputs "second". Do not change or remove this line.
        printSecond();
        second.Signal();
    }

    public void Third(Action printThird) {
        second.Wait();
        // printThird() outputs "third". Do not change or remove this line.
        printThird();
    }
}
