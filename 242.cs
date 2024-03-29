// LeetCode 242
// convert to char array, sort and compare

public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }

        var arrS = s.ToCharArray();
        var arrT = t.ToCharArray();

        Array.Sort(arrS);
        Array.Sort(arrT);

       return (new string(arrS) == new string(arrT));
    }
}