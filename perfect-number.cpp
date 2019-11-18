class Solution {
public:
    bool checkPerfectNumber(int num) {
         if (num <= 0) {
            return false;
        }
        int sum = 2 * num;
        for (int i = 1; i * i <= num; i++) {
            if (num % i == 0) {
                sum -= i;
                if (i * i != num) {
                    sum -= num / i;
                }

            }
        }
        cout << sum << endl;
        return !sum;
    }
};
