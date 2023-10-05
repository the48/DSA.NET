// LeetCode 14

class Solution {
    public string solve(string[] strs) {
        if(strs.Length == 0) {
            return "";
        }
        string prefix = strs[0];

        for(int i = 0; i < strs.Length; i++) {
            string _prefix = "";

            for(int k = 0; k < strs[i].Length; k++) {
                if(k >= prefix.Length) {
                    break;
                }

                if(strs[i][k] == prefix[k]) {
                    _prefix += strs[i][k];
                }

                else {
                    break;
                }
                
            }
            prefix = _prefix;
        }
        return prefix;
    }
}