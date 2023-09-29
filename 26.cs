// LeetCode 26

class Solution {
    public int solve(int[] nums) {
        int l = 1;

        for(int r = 1; r < nums.Length; r++) {
            if(nums[r] != nums[r - 1]) {
                nums[l] = nums[r];
                l += 1;
            }
        }
        return l;
    }
}