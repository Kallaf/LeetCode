class Solution {
    public String intToRoman(int num) {
        char[] one = new char[]{'I', 'X', 'C', 'M'};
        char[] five = new char[]{'V', 'L', 'D'};
        Stack<Integer> stk= new Stack<>();
        int digit = -1;
        while (num > 0) {
            stk.push(num%10);
            num/=10;
            digit++;
        }
        StringBuilder sb = new StringBuilder();
        while(!stk.empty()) {
            int d = stk.pop();
            if (d == 4) {
               sb.append(one[digit]);
               sb.append(five[digit]); 
            } else if (d == 9) {
               sb.append(one[digit]);
               sb.append(one[digit+1]); 
            } else if (d >= 1) {
                int base = d >= 5 ? 5 : 1;
                sb.append(base == 1?one[digit]:five[digit]);
                for(int i=d-base;i>0;i--)sb.append(one[digit]);
            }
            digit--;
        }
        return sb.toString();
    }
}
