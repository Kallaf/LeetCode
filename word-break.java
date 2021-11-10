class Solution {
    public boolean wordBreak(String s, List<String> wordDict) {
        Trie trie = new Trie(wordDict);
        char[] ch = s.toCharArray();
        Cache memory = new Cache(trie, ch);
        return wordBreak(0, memory);
    }
    
    private boolean wordBreak(int start, Cache memory) {
        if(memory.visited[start]) return memory.isSentence[start];
        memory.visited[start] = true;
        List<Integer> idxs = memory.trie.findWordsEnds(memory.ch, start);
        if(idxs.isEmpty()) return memory.isSentence[start] = false;
        if(idxs.contains(memory.ch.length)) return memory.isSentence[start] = true;
        for (int idx : idxs) {
            memory.isSentence[start] = wordBreak(idx, memory);
            if(memory.isSentence[start]) return true;
        }
        return false;
    }
    
    static class Cache {
        public boolean[] visited;
        public boolean[] isSentence;
        public Trie trie;
        public char[] ch;
        
        public Cache(Trie trie, char[] ch) {
            this.ch = ch;
            this.trie = trie;
            isSentence = new boolean[ch.length];
            visited = new boolean[ch.length];
        }
    }
    
    static class Trie {
        private Node root;

        public Trie(List<String> wordDict) {
            root = new Node('#');
            for (String word : wordDict) {
                insert(word);
            }
        }

        public void insert(String word) {
            char[] ch = word.toCharArray();
            Node iter = root;
            for (int i=0; i<ch.length; i++) {
                int idx = ch[i] - 'a';
                if (iter.next[idx] == null) {
                    iter.next[idx] = new Node(ch[i]);
                }
                iter = iter.next[idx];
                if (i == ch.length - 1) iter.isWordEnd = true;
            }
        }

        public List<Integer> findWordsEnds(char[] ch, int start) {
            List<Integer> wordsEnds = new ArrayList<>();
            Node iter = root;
            for (int i=start; i < ch.length; i++) {
                int idx = ch[i] - 'a';
                if (iter.next[idx] == null) break;
                iter = iter.next[idx];
                if (iter.isWordEnd) wordsEnds.add(i + 1);
            }
            return wordsEnds;
        }
    }

    public static class Node {
        public char value;
        public Node[] next;
        public boolean isWordEnd; 

        public Node(char value) {
            this.value = value;
            this.next = new Node[26];
        }
    }
    
}
