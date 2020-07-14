public class Solution {
    public double AngleClock(int hour, int minutes) {
        hour %= 12;
        double htom = hour * 5 + (double)minutes/12;
        double diff = Math.Abs(htom - minutes);
        double mins = Math.Min(
            diff,
            60 - diff
        );
        return mins * 6;
    }
}
