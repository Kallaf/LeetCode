class Solution {
    public int numJewelsInStones(String J, String S) {
        boolean[] isJewels = new boolean[100];
        for(char c:J.toCharArray())isJewels[c-'A'] = true;
        int count = 0;
        for(char c:S.toCharArray())count += isJewels[c-'A']?1:0;
        return count;
    }
}
