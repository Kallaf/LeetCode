class Solution {
public:
    string getHint(string secret, string guess) {
        int countb[11] = {0},countg[11] = {0};
        for(int i=0;i<secret.length();i++)
            countb[secret[i]-'0']++;
        int bulls = 0,cows = 0;
        for(int i=0;i<guess.length();i++)
        {
            if(i<secret.size() && secret[i] == guess[i])
            {
                bulls++;
                countb[secret[i]-'0']--;
            }else
                countg[guess[i]-'0']++;
        }
        
        for(int i =0;i<10;i++)
            cows += min(countb[i],countg[i]);
        return to_string(bulls)+"A"+to_string(cows)+"B";
    }
};

static auto _ = [](){
    ios::sync_with_stdio(false);
    cin.tie(NULL);
    cout.tie(NULL);
};
