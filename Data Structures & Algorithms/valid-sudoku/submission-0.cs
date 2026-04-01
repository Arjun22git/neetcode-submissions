public class Solution {
    public bool IsValidSudoku(char[][] board) {

        for(int i=0;i<9;i++){
            HashSet<char> currentRow = new HashSet<char>();
            for(int j=0;j<9;j++){
                if(board[i][j] == '.')
                    continue;
                if (currentRow.Contains(board[i][j]))
                      return false;
                
                else {
                    currentRow.Add(board[i][j]);
                }
            }
        }
        for(int i=0;i<9;i++){
            HashSet<char> currentColumn = new HashSet<char>();
            for(int j=0;j<9;j++){
                if(board[j][i] == '.')
                    continue;
                if (currentColumn.Contains(board[j][i])){
                      return false;
                }
                else {
                    currentColumn.Add(board[j][i]);
                }
            }
        }
        for(int box=0;box<9;box++){
            HashSet<char> currentBox= new HashSet<char>();
            for(int i=0;i<3;i++){
                for(int j=0;j<3;j++){
                    int row = (box/3)*3+i;
                    int col = (box%3)*3+j;
                    if(board[row][col] == '.')
                        continue;
                    if (currentBox.Contains(board[row][col])){
                        return false;
                    }
                    else {
                        currentBox.Add(board[row][col]);
                    }
                }
            }
            
        }
        return true;
    }
}
