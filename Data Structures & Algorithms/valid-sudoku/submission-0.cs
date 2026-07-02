public class Solution {
    // lets attempt the brute force solution
    // we should satisfy the first condition first
    public bool IsValidSudoku(char[][] board) {
        
        for(int row = 0;row<board.Length;row++){
            HashSet<char> dupRow = new HashSet<char>();

            for(int i = 0;i<board[row].Length;i++){
                
                if(board[row][i]=='.') continue;
                if(dupRow.Contains(board[row][i])){
                    return false;
                }
                dupRow.Add(board[row][i]);
            }
        }


        for(int col = 0; col <board[0].Length; col++){
            HashSet<char> dupCol = new HashSet<char>();

            for(int i = 0; i<board.Length;i++){
                if(board[i][col]=='.') continue;
                if(dupCol.Contains(board[i][col])){
                    return false;
                }
                dupCol.Add(board[i][col]);
            }
        }
        for(int square = 0; square < 9;square++){
             HashSet<char> dupSquare = new HashSet<char>();

            for(int i = 0; i< 3; i++){
                for(int j = 0; j < 3; j++){

                    int row  = (square / 3) * 3 + i;
                    int col = (square % 3 ) * 3 + j;
                    if(board[row][col]=='.') continue;
                    if(dupSquare.Contains(board[row][col])){
                        return false;
                    }
                    dupSquare.Add(board[row][col]);
                }
            }
        }
        return true;
    }
}
