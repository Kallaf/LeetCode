public class StockSpanner {

    private int[] prices;
    private int[] spans;
    private int curr = 0;
    
    public StockSpanner() {
        prices = new int[150001];
        spans = new int[150001];
    }
    
    public int Next(int price) {
        prices[curr] = price;
        spans[curr] = 1;
        int prev = curr - 1;
        while(prev >= 0)
        {
            if(prices[prev] <= prices[curr])
                spans[curr] += spans[prev];
            else
                break;
            prev -= spans[prev];
        }
        curr++;
        return spans[curr-1];
    }
}
