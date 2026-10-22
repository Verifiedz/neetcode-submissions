public class Solution {

    // given m x n 2-D matrix 
    // target integer
    /*
    each row is sorted asc
    first int in each row is greater than last integer
    
    return true if target exists within matrix or false otherwise
    
    we need a sol that rusn in 0(log(m * n))

        for the big 0 notation we must scan both the rows and the cols

        approach:
            we need to apply a binary search algorithm

                but since this is a 2D matrix we need to chec each on 1D
                and then we can return to check the final res in 2D

        // we convert the 2D and row by keeping the row constant
        // once converted we apply the normal binary Search Algorithm
        //  then we iterate increasing the row.

        attempt:

            instead resulting in nested for loop 

            for us to run the binary search but change the result to 1D
             case convert it useing an equation

             we can still have our left and right pointers
             which will represent the ends of the matrix

             and the mid point will determine the  new row and col

             as reduce the scope of the search
             Because of that, you can use the exact same binary search template you just learned. You set left = 0 and right = (total_elements) - 1.

The only missing piece of knowledge is how to convert your 1D mid calculation back into a 2D coordinate so you can actually check matrix[row][col]. Here is the formula you need to memorize for grid problems:

If you have a matrix with C columns:

    row = mid / C (Integer division tells you how many full rows you've passed)

    col = mid % C (Modulo tells you how many spots you are into the current row)

             int row = 0;
             int col = 0;
             int left = 0; 
             int right = matrix.Length * matrix.[0].Length - 1;

             while (left <= right){
                mid = left + (right - left)/2;

                if(matrix[mid/cols][mid % cols] == target){
                    return true;
                }

                if(matrxi[mid/cols][mid % cols] < target){
                    left = mid + 1;
                }

                if(matrix[mid /cols][mid % cols] > target){
                    right = mid - 1;
                }
             }
                return false;
    */ 
    public bool SearchMatrix(int[][] matrix, int target) {
        int row = matrix.Length;
        int col = matrix[0].Length;
        int left = 0; 
        int mid = 0;
        int right = row * col - 1;

        while(left <= right){
            mid = left + (right - left)/2;
            if(matrix[mid / col][mid % col] == target){
                return true;
            }

            if(matrix[mid / col][mid % col] < target){
                left = mid + 1;
            }
 
            if(matrix[mid / col][mid % col] >  target){
                right = mid - 1;
            }
 
        }
        return false;
    }
}
