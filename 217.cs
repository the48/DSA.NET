// LeetCode 217
using System.Collections.Generic;

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> arrHash = new HashSet<int>();

        for(int i = 0; i < nums.Length; i++) {
            if (arrHash.Contains(nums[i])) {
                return true;
                }
            arrHash.Add(nums[i]);
        }
        return false;
    }
}
