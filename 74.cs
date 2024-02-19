public class Solution (
    public bool solve(int[][] matrix, int target) (
        int rowsCount = matrix.Length;
        int colsCount = matrix[0].Length;
        int topPointer = 0;
        int botPointer = colsCount - 1;
        int row = 0;

        // Binary Search on ends of Columns
        while (topPointer <= botPointer) {
            row = (topPointer + botPointer) / 2;
            if (target > matrix[row][botPointer]) {
                topPointer = row + 1;
            }
            else if (target < matrix[row][botPointer]) {
                botPointer = row - 1;
            }
            else {
                break;
            }
        }

        if (topPointer > botPointer) {
            return false;
        }

        int leftPointer = 0;
        int rightPointer = colsCount - 1;

        // Binary Search on Row
        while (leftPointer <= rightPointer) {
            int midPointer = (leftPointer + rightPointer) / 2;
            
            if (target > matrix[row][midPointer]) {
                leftPointer = midPointer + 1;
            }
            else if (target < matrix[row][midPointer]) {
                rightPointer = midPointer - 1;
            }
            else {
                return true;
            }
        }

        // None
        return false
    )
)