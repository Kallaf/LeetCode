class Solution {
private:
    string spaces(int len)
    {
        string space = "";
        while(len--)space+=" ";
        return space;
    }
public:
    vector<string> fullJustify(vector<string>& words, int maxWidth) {
        vector<string> ans;
        if(words.empty())return ans;
        int start = 0,width = words[0].length(),cnt=1;
        for(int i=1;i<words.size();i++)
        {
            if(width+1+words[i].length() <= maxWidth)
            {
                width += words[i].length()+1;
                cnt++;
            }else{
                string line = "";
                if(cnt == 1)
                    line += words[start] + spaces(maxWidth - words[start].length());   
                else{
                    int space_length = (maxWidth-width)/(cnt-1);
                    int rem = (maxWidth-width)%(cnt-1);
                    line += words[start];
                    string prev = spaces(space_length + (rem?1:0) +1);
                    if(rem)rem--;
                    for(int j=start+1;j<start+cnt;j++)
                    {
                        line += prev + words[j];
                        prev = spaces(space_length + (rem?1:0) +1);
                        if(rem)rem--;
                    }
                }
                assert(line.length() == maxWidth);
                ans.push_back(line);
                start = start+cnt;width = words[start].length();cnt=1;
            }
        }
        assert(start != words.size());
        string line = "";
        line += words[start];
        for(int j=start+1;j<start+cnt;j++)
            line += " " + words[j];

        line +=  spaces(maxWidth - line.length());
        ans.push_back(line);
        
        return ans;
    }
};
