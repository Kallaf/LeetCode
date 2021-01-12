class Solution {
    
    private HashMap<String,ArrayList<Integer>> neighbors;
    private boolean[] visited;
    private int n;
    Queue<int[]> q;
    
    public int ladderLength(String beginWord, String endWord, List<String> wordList) {
        if(!wordList.contains(endWord))return 0;
        constructGraph(beginWord,wordList);
        return bfs(beginWord,wordList.indexOf(endWord),wordList);
    }
    
    private void constructGraph(String beginWord,List<String> words)
    {
        neighbors = new HashMap<String,ArrayList<Integer>>();
        n = beginWord.length();
        int i=0;
        for(String word:words)
        {
            for(int j=0;j<n;j++)
            {
                String key = getNeighbor(word,j);
                ArrayList<Integer> value = neighbors.getOrDefault(key, new ArrayList<Integer>());
                value.add(i);
                neighbors.put(key,value);
            }
            i++;
        }
        q = new LinkedList<int[]>();
        visited = new boolean[words.size()+10];
    }
    
    private int bfs(String beginWord, int endWordIndex, List<String> wordList)
    {
        push(wordList.size(),1);
        wordList.add(beginWord);
        while(!q.isEmpty())
        {
            int[] p = q.remove();
            String word = wordList.get(p[0]);
            int depth = p[1];
            for(int i=0;i<n;i++)
            {
                List<Integer> arr = neighbors.getOrDefault(
                    getNeighbor(word,i),new ArrayList<Integer>()
                );
                for(int j:arr)
                {
                    if(j == endWordIndex)
                    {
                        return depth+1;
                    }
                    if(!visited[j])
                    {
                        visited[j] = true;
                        push(j,depth+1);
                    }
                }
            }
        }
        return 0;
    }
    
    private String getNeighbor(String word,int idx)
    {
        return word.substring(0,idx) + "#" + word.substring(idx+1);
    }
    
    private void push(int index,int depth)
    {
        int[] pair = new int[]{index,depth};
        q.add(pair);
    }
}
