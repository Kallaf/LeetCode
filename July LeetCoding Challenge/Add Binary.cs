public class Solution {
    
    public class Sum{
        private char carry;
        private StringBuilder sum;
        public Sum()
        {
            carry = (char)0;
            sum = new StringBuilder();
        }
        
        public void Add(char a,char b)
        {
            char s = (char)(a ^ b ^ carry);
            sum.Insert(0, (char)(s + '0'));
            carry = (char)(a & b | carry & (a ^ b));
        }
        
        public string getSum()
        {
            return carry==1? sum.Insert(0, '1').ToString(): sum.ToString();
        }
    }
    
    public string AddBinary(string a, string b) {
        Sum s = new Sum();
        int i=a.Length-1,j=b.Length-1;
        for(;i>=0&&j>=0;i--,j--)
            s.Add((char)(a[i] - '0'),(char)(b[j] - '0'));
        
        for(;i>=0;i--)
            s.Add((char)(a[i] - '0'),(char)0);
        
        for(;j>=0;j--)
            s.Add((char)0,(char)(b[j] - '0'));
        
        return s.getSum();
    }
}
