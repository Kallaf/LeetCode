class Solution {
public:
    vector<int> diffWaysToCompute(string input) {
        vector<int> ans;
        if(input == "")return ans;
        bool flag = false;
        for(int i=0;i<input.length();i++)
        {
            
                if(!isdigit(input[i]))
                {
                    string number1 = input.substr(0,i);
                    string number2 = input.substr(i+1);
                    vector<int> left = diffWaysToCompute(number1),right = diffWaysToCompute(number2);
                    for(int j=0;j<left.size();j++)
                    for(int k=0;k<right.size();k++)
                    {
                        if(input[i] == '+')
                            ans.push_back(left[j]+right[k]);
                        else if(input[i] == '-')
                            ans.push_back(left[j]-right[k]);
                        else
                            ans.push_back(left[j]*right[k]);
                    }
                    flag = true;
                }
           
        }
            
        if(!flag)ans.push_back(stoi(input));
        return ans;
    }
};
