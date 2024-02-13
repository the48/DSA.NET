// LeetCode 1
// if difference between target and array[i] is in the dictionary, return the index of the array and the index of the target
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> twosum = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++) {
        if (twosum.ContainsKey(target - nums[i])) {
            return new int[] { twosum[target - nums[i]], i };
        }
        twosum[nums[i]] = i;
    }


    return new int[] {0};
}
}