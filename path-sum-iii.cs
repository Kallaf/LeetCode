public class Solution {
    private int PathSum(TreeNode root,int sum,Dictionary<int,int> cnt)
    {
       int ans = 0; 
       if(root.left!=null)
       {
           Dictionary<int,int> leftCnt = new Dictionary<int,int>();
           leftCnt.Add(root.left.val,1);
           ans += PathSum(root.left,sum,leftCnt);
           foreach(KeyValuePair<int,int> entry in leftCnt)
           {
               int x = entry.Key + root.val;
               if(!cnt.ContainsKey(x))
                   cnt.Add(x,0);
               cnt[x] += entry.Value;
           }
       }
        
       if(root.right!=null)
       {
           Dictionary<int,int> rightCnt = new Dictionary<int,int>();
           rightCnt.Add(root.right.val,1);
           ans += PathSum(root.right,sum,rightCnt);
           foreach(KeyValuePair<int,int> entry in rightCnt)
           {
               int x = entry.Key + root.val;
               if(!cnt.ContainsKey(x))
                   cnt.Add(x,0);
               cnt[x] += entry.Value;
           }
       }
        
       foreach(KeyValuePair<int,int> entry in cnt)
       {
           if(entry.Key == sum)
               ans+=entry.Value;
       }
       return ans;
    }
    
    public int PathSum(TreeNode root, int sum) {
        if(root==null)return 0;
        Dictionary<int,int> cnt = new Dictionary<int,int>();
        cnt.Add(root.val,1);
        return PathSum(root,sum,cnt);
    }
}
