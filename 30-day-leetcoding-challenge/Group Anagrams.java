class Solution {
    
    private class Pair implements Comparable<Pair> {
    String label1;
    String label2;
    public Pair(String label1,String label2){
        this.label1 = label1;
        this.label2 = label2;
    }

    @Override
    public int compareTo(Pair o) {
        return this.label1.compareTo(o.label1);
    }
}
    
    public List<List<String>> groupAnagrams(String[] strs) {
        Pair[] arr = new Pair[strs.length];
        for(int i=0;i<strs.length;i++)
        {
            char tempArray[] = strs[i].toCharArray();
            Arrays.sort(tempArray);
            arr[i] = new Pair(new String(tempArray),strs[i]);
        }
        List<List<String>> res = new ArrayList<List<String>>();
        Arrays.sort(arr);
        for(int i=0;i<arr.length;i++)
        {
            if(i == 0 || !arr[i].label1.equals(arr[i-1].label1))
                res.add(new ArrayList<String>(Arrays.asList(arr[i].label2)));
            else
                res.get(res.size()-1).add(arr[i].label2);
        }
        return res;
    }
}
