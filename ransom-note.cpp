class Solution {
public:
    bool canConstruct(string ransomNote, string magazine) {
        int count1[30] = {0};
        int count2[30] = {0};
        for(int i=0;i<ransomNote.size();i++)
            count1[ransomNote[i] - 'a']++;
        for(int i=0;i<magazine.size();i++)
            count2[magazine[i] - 'a']++;
        for(int i=0;i<26;i++)
            if(count2[i] < count1[i])
                return false;
        return true;
    }
};
