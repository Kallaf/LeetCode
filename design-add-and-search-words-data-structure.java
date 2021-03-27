class WordDictionary {

    // Alphabet size (# of symbols)
    static final int ALPHABET_SIZE = 26;
    
    // trie node
    class TrieNode
    {
        TrieNode[] children = new TrieNode[ALPHABET_SIZE];
       
        // isEndOfWord is true if the node represents
        // end of a word
        boolean isEndOfWord;
          
        TrieNode(){
            isEndOfWord = false;
            for (int i = 0; i < ALPHABET_SIZE; i++)
                children[i] = null;
        }
    };
    
    private TrieNode root; 
    
    /** Initialize your data structure here. */
    public WordDictionary() {
        root = new TrieNode();
    }
    
    public void addWord(String word) {
        int level;
        int length = word.length();
        int index;
       
        TrieNode pCrawl = root;
       
        for (level = 0; level < length; level++) {
            index = word.charAt(level) - 'a';
            if (pCrawl.children[index] == null)
                pCrawl.children[index] = new TrieNode();
       
            pCrawl = pCrawl.children[index];
        }
       
        // mark last node as leaf
        pCrawl.isEndOfWord = true;
    }
    
    public boolean search(String word) {
        return search(word, root);
    }
    
    public boolean search(String word, TrieNode pCrawl) {
        int level;
        int length = word.length();
        int index;
        
        for (level = 0; level < length; level++)
        {
            char ch = word.charAt(level);
            if (ch == '.') {
                String subword = word.substring(level+1);
                for (int i = 0; i < ALPHABET_SIZE; i++) {
                    if (pCrawl.children[i] != null && search(subword, pCrawl.children[i])) {
                        return true;
                    }
                }
                return false;
            } else {
                index = ch - 'a';

                if (pCrawl.children[index] == null)
                    return false;

                pCrawl = pCrawl.children[index];
            }
            
        }
       
        return (pCrawl != null && pCrawl.isEndOfWord);
    }
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.addWord(word);
 * boolean param_2 = obj.search(word);
 */
