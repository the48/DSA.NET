public class Solution {
    public int FirstUniqChar(string s) {

        Dictionary<char, int> dic = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++) {
            if (dic.ContainsKey(s[i])) {
                dic[s[i]]++;
            }
            else {
                dic[s[i]] = 1;
            }
        }

        for (int j = 0; j < s.Length; j++) {
            if (dic[s[j]] == 1) {
                return j;
            }
        }

        return -1;
    }
}