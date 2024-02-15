public class Solution {
    public bool IsPalindrome(string s) {

        int leftPointer = 0;
        int rightPointer = s.Length - 1;

        while ( leftPointer < rightPointer) {
            if (!char.IsLetterOrDigit(s[leftPointer])) {
                leftPointer++;
            }
            else if (!char.IsLetterOrDigit(s[rightPointer])) {
                rightPointer--;
            }
            else {
                if (char.ToLower(s[rightPointer]) != char.ToLower(s[leftPointer])) {
                    return false;
                }
                leftPointer++;
                rightPointer--;
            }     
        }
        return true;
    }
}