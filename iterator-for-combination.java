class CombinationIterator {

    private static int countOnes(int x)
    {
        int cnt = 0;
        while(x>0)
        {
            if((x&1) == 1)
                cnt++;
            x>>=1;
        }
        return cnt;
    }
    
    private static String createPer(int x,char[] ch)
    {
        StringBuilder per = new StringBuilder();
        for(int i=0;i<ch.length;i++)
            if(((1<<i)&x) != 0)
                per.append(ch[i]);
        return per.toString();
    }
    
    private ArrayList<String> per;
    private int it;
    public CombinationIterator(String characters, int combinationLength) {
        per = new ArrayList<String>();
        it = 0;
        char[] ch = characters.toCharArray();
        int max = 1 << ch.length;
        for(int i=1;i<max;i++)
            if(countOnes(i) == combinationLength)
             per.add(createPer(i,ch));
        Collections.sort(per);
    }
    
    public String next() {
        return per.get(it++);
    }
    
    public boolean hasNext() {
        return it < per.size();
    }
}

/**
 * Your CombinationIterator object will be instantiated and called as such:
 * CombinationIterator obj = new CombinationIterator(characters, combinationLength);
 * String param_1 = obj.next();
 * boolean param_2 = obj.hasNext();
 */
