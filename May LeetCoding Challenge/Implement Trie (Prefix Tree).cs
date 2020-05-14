public class Trie {

    private class Node{
        
        public int[] index;
        public Node()
        {
            index = new int[27];
            Array.Fill(index,-1);
        }
        
    }
    
    private List<Node> v;
    /** Initialize your data structure here. */
    public Trie() {
        v = new List<Node>();
        v.Add(new Node());
    }
    
    /** Inserts a word into the trie. */
    public void Insert(string word) {
        Node curr = v[0];
        foreach(char c in word)
        {
            if(curr.index[c-'a'] == -1){
                curr.index[c-'a'] = v.Count;
                v.Add(new Node());
            }
            curr = v[curr.index[c-'a']];
        }
        if(curr.index[26] == -1){
            curr.index[26] = v.Count;
            v.Add(new Node());
        }
    }
    
    /** Returns if the word is in the trie. */
    public bool Search(string word) {
        Node curr = v[0];
        foreach(char c in word)
        {
            if(curr.index[c-'a'] == -1)return false;
            curr = v[curr.index[c-'a']];
        }
        return curr.index[26] != -1;
    }
    
    /** Returns if there is any word in the trie that starts with the given prefix. */
    public bool StartsWith(string prefix) {
        Node curr = v[0];
        foreach(char c in prefix)
        {
            if(curr.index[c-'a'] == -1)return false;
            curr = v[curr.index[c-'a']];
        }
        return true;
    }
}
