#include <pthread.h> 
#include <semaphore.h> 

class Foo {
private:
    sem_t secondLock;
    sem_t thirdLock;
public:
    Foo() {
        sem_init(&secondLock, 0, 0); 
        sem_init(&thirdLock, 0, 0); 
    }
    
    ~Foo() {
        sem_destroy(&secondLock);
        sem_destroy(&thirdLock);
    }

    void first(function<void()> printFirst) {
        // printFirst() outputs "first". Do not change or remove this line.
        printFirst();
        sem_post(&secondLock);
    }

    void second(function<void()> printSecond) {
        sem_wait(&secondLock);
        // printSecond() outputs "second". Do not change or remove this line.
        printSecond();
        sem_post(&thirdLock);
    }

    void third(function<void()> printThird) {
        sem_wait(&thirdLock);
        // printThird() outputs "third". Do not change or remove this line.
        printThird();
    }
};
