// LeetCode 3 : sliding window

public class Solution {
    public int LengthOfLongestSubstring(string s) {

        var hashset = new HashSet<char>();
        int leftPointer = 0;
        int maxLength = 0;

        for (int rightPointer = 0; rightPointer < s.Length; rightPointer++) {
            while (hashset.Contains(s[rightPointer])) {
                hashset.Remove(s[leftPointer]);
                leftPointer++;
            }

            hashset.Add(s[rightPointer]);
            maxLength = Math.Max(maxLength, rightPointer - leftPointer + 1);
        }

        return maxLength;
}