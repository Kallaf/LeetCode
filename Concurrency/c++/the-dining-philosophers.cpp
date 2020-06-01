#include <pthread.h> 
#include <semaphore.h> 
class DiningPhilosophers {
private:
    vector<sem_t> fork;
    sem_t mutex;
public:
    DiningPhilosophers() {
        fork.resize(5);
        sem_init(&mutex, 0, 1); 
        for(int i=0;i<5;i++)
            sem_init(&fork[i], 0, 1); 
    }
    
    ~DiningPhilosophers() {
        sem_destroy(&mutex); 
        for(int i=0;i<5;i++)
            sem_destroy(&fork[i]); 
    }

    void wantsToEat(int philosopher,
                    function<void()> pickLeftFork,
                    function<void()> pickRightFork,
                    function<void()> eat,
                    function<void()> putLeftFork,
                    function<void()> putRightFork) {
		sem_wait(&mutex); 
        
        sem_wait(&fork[philosopher]); 
        sem_wait(&fork[(philosopher+1)%5]); 
        
        sem_post(&mutex); 
        
        pickLeftFork();
        pickRightFork();
        eat();
        putLeftFork();
        putRightFork();
        
        sem_post(&fork[philosopher]); 
        sem_post(&fork[(philosopher+1)%5]); 
    }
};
