// LeetCode #88
class Solution {
    public static int[] solve(int[] arr1, int[] arr2, int m, int n, int i) {
        int last = m + n - 1;

        while (m > 0 && n > 0) {
            if (arr1[m - 1] > arr2[n - 1]) {
                arr1[last] = arr1[m - 1];
                m -= 1;
            }
            else {
                arr1[last] = arr2[n - 1];
                n -= 1;
            }
            last -= 1;
        }

        while(n > 0) {
            arr1[last] = arr2[n - 1];
            n -= 1;
            last -= 1;
        }
    }
}