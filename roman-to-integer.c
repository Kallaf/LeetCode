

int romanToInt(char * s){
    int roman[30];
    roman['I'-'A'] = 1;roman['V'-'A'] = 5;
    roman['X'-'A'] = 10;roman['L'-'A'] = 50;
    roman['C'-'A'] = 100;roman['D'-'A'] = 500;
    roman['M'-'A'] = 1000;
    
    int sum = 0;
    for(int i=0;s[i];i++)
    {
        if(s[i+1] && roman[s[i]-'A']<roman[s[i+1]-'A'])
            sum += -1 * roman[s[i]-'A'];
        else
            sum += roman[s[i]-'A'];
    }
    return sum;
}

