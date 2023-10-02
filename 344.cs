// LeetCode 344

class Solution {
    public string solve(char[] s) {
        int l = 0;
        int r = s.Length - 1;

        while (l <= r) {
            char t = s[l];

            s[l] = s[r];
            s[r] = t;

            l += 1;
            r -= 1;
        }
    }
}