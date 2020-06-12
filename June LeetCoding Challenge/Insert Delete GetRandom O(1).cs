public class RandomizedSet {

    private List<int> arr;
    private Dictionary<int,int> nums;
    private Random rand;
    /** Initialize your data structure here. */
    public RandomizedSet() {
        arr = new List<int>();
        nums = new Dictionary<int,int>();
        rand = new Random();
    }
    
    /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
    public bool Insert(int val) {
        if(nums.ContainsKey(val)){
            return false;
        }
        nums.Add(val,arr.Count);
        arr.Add(val);
        return true;
    }
    
    /** Removes a value from the set. Returns true if the set contained the specified element. */
    public bool Remove(int val) {
        if(!nums.ContainsKey(val)){
            return false;
        }
        int index = nums[val];
        int lastElement = arr[arr.Count-1];
        arr[index] = lastElement;
        nums[lastElement] = index;
        arr.RemoveAt(arr.Count - 1);
        nums.Remove(val);
        return true;
    }
    
    /** Get a random element from the set. */
    public int GetRandom() {
        return arr[rand.Next(arr.Count)];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */
