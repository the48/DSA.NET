// LeetCode 28

class Solution {
    public int solve(string haystack, string needle) {
        if(needle == null) {
            return 0;
        }

        for(int i = 0; i < haystack.Length + 1 - needle.Length; i++) {
            for(int j = 0; j < needle.Length; j++) {
                if(haystack[i + j] != needle[j]){
                    break;
                }
                if(j == needle.Length - 1) {
                    return i;
                }
            }
        }
        return -1;
    }
}