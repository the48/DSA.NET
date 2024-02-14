// LeetCode 53 : using Kadane's

class Solution
{
    public int solve(int[] arr)
    {
        int workingSum = 0;
        int maxSum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            workingSum = Math.Max(workingSum, 0);
            workingSum += arr[i];

            maxSum = Math.Max(workingSum, maxSum);
        }

        return maxSum;
    }
}