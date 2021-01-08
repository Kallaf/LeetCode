class Solution {
    public boolean arrayStringsAreEqual(String[] word1, String[] word2) {
        return concate(word1).compareTo(concate(word2)) == 0;
    }
    
    private StringBuilder concate(String[] words)
    {
        StringBuilder sb = new StringBuilder();
        for(String word:words)sb.append(word);
        return sb;
    }
}
