class Solution {
    private int max = 0;
    public int maxLength(List<String> arr) {
        List<Integer> masks = new ArrayList<>();
        for (String str : arr) {
            char[] ch = str.toCharArray();
            if (isUnique(ch)) {
                masks.add(toMask(ch));
            }
        }
        return maxLength(masks.toArray(new Integer[masks.size()]));
    }
    
    private int maxLength(Integer[] masks) {
        int res = 0;
        List<Integer> db = new ArrayList<>();
        db.add(0);
        for (Integer mask : masks) {
            for(int i=db.size() - 1;i >= 0; i--) {
                int x = db.get(i);
                if ((x & mask) == 0) {
                    db.add(x | mask);
                    res = Math.max(res, getLength(x | mask));
                }
            }
        }
        return res;
    }
    
    private boolean isUnique(char[] ch) {
        int x = 0;
        for (int i=0;i<ch.length;i++) {
            int shift = ch[i] - 'a';
            int y = 1 << shift;
            if ((x & y) != 0) {
                return false;
            }
            x ^= y;
        }
        return true;
    }
    
    private int toMask(char[] ch) {
        int x = 0;
        for (int i=0;i<ch.length;i++) {
            int shift = ch[i] - 'a';
            int y = 1 << shift;
            x ^= y;
        }
        return x;
    }
    
    private int getLength(Integer x) {
        int len = 0;
        while(x > 0) {
            len += x & 1;
            x >>= 1;
        }
        return len;
    }
}
