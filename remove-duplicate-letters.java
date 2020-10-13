class Solution {
    public String removeDuplicateLetters(String s) {
        char[] ch = s.toCharArray();
        int[] freq = new int[30];
        for(int i=0;i<ch.length;i++)
        {
            freq[ch[i] - 'a']++;
        }
        Stack<Character> stack = new Stack<Character>();
        boolean[] isInStack = new boolean[30];
        for(int i=0;i<ch.length;i++)
        {
            if(!isInStack[ch[i]-'a'])
            {
                if(stack.empty())
                {
                    stack.push(ch[i]);
                }else{
                    if(ch[i] > stack.peek())
                    {
                        stack.push(ch[i]);
                    }else if(ch[i] < stack.peek())
                    {
                        while(!stack.empty() &&
                              ch[i] < stack.peek() &&
                              freq[stack.peek()-'a'] != 0
                        ){
                            isInStack[stack.pop()-'a'] = false;
                        }
                        stack.push(ch[i]);
                    }
                }
                isInStack[ch[i]-'a'] = true; 
            }
            freq[ch[i]-'a']--;
        }
        StringBuilder stringBuilder = new StringBuilder();
        while(!stack.empty())
        {
            stringBuilder.append(stack.pop()); 
        }
        return stringBuilder.reverse().toString();
    }
}
