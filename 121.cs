// LeetCode 121

class Solution {
    public solve(int[] arr) {
        int l = 0;
        int r = 1;
        int maxProfit = 0;

        while(r < arr.Length) {
            if(arr[l] < arr[r]) {
                int profit = arr[r] - arr[l];
                maxProfit = Math.Max(profit, maxProfit);
            }
            else {
                l = r;
            }
            r += 1;
        }
    }
}