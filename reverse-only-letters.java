class Solution {
    public String reverseOnlyLetters(String s) {
        char[] ch = s.toCharArray();
        int index = ch.length - 1;
        StringBuilder sb = new StringBuilder();
        for(int i=0;i<ch.length;i++) {
            if ((ch[i] < 'a' || 'z' < ch[i]) && (ch[i] < 'A' || 'Z' < ch[i])) {
                sb.append(ch[i]);
            } else {
                while((ch[index] < 'a' || 'z' < ch[index]) && (ch[index] < 'A' || 'Z' < ch[index])) index--;
                sb.append(ch[index--]);
            }
        }
        return sb.toString();
    }
}
