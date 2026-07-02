public class Solution {
    public bool IsValidSudoku(char[][] board) {

        HashSet<char> rset;
        HashSet<char> cset;
  HashSet<string> subBox = new HashSet<string>();
  //subBox hashset is outside since we need it alive for all boxes
  //we only added teh other hashset inside the loop for a refresh after a row or col

        

        for(int row = 0; row<board.Length;row++){
            rset = new HashSet<char>();


            for(int col= 0; col<board.Length;col++){

                if(board[row][col] == '.'){
                    continue;
                }
                if(!rset.Contains(board[row][col])){
                    rset.Add(board[row][col]);
                }
                else{
                    return false;
                }
            }
        }
        for(int col = 0; col<board.Length;col++){
            cset = new HashSet<char>();

            for(int row = 0; row<board.Length;row++){

                if(board[row][col] == '.'){
                    continue;
                }
                if(!cset.Contains(board[row][col])){
                    cset.Add(board[row][col]);
                }
                else{
                    return false;
                }
            }
        }

        for(int row = 0; row < board.Length; row++){

           
            for(int col = 0; col <board.Length;col++){

           var currentvalue = board[row][col];
           string rowValue = $"{currentvalue} in row {row}";
           string colValue = $"{currentvalue} in col {col}";
           string boxValue = $"{currentvalue} in box {row/3},{col/3}";

                if(board[row][col] == '.'){
                    continue;
                }
                if(!subBox.Add(rowValue) ||!subBox.Add(colValue) || !subBox.Add(boxValue)){
                    return false;
                }
                
            }
        }
        return true;
    }
}

