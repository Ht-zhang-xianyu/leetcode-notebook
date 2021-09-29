class Solution(object):
    def isValidSudoku(self, board):
        """
        :type board: List[List[str]]
        :rtype: bool
        """
        # 建立3个矩阵，用以记数不同模块的数字数量，超过2就返回False
        row_index = [[0] * 9 for _ in range(9)]
        col_index = [[0] * 9 for _ in range(9)]
        sub_block = [[[0] * 9 for _ in range(3)] for _ in range(3)]
        # 循环 
        for i in range(9):
            for j in range(9):
                if board[i][j].isdigit():
                    num = int(board[i][j])
                    row_index[i][num-1] += 1 
                    col_index[num-1][j] += 1 
                    sub_block[i/3][j/3][num-1] += 1 
                    if row_index[i][num-1] > 1 or col_index[num-1][j] > 1 or sub_block[i/3][j/3][num-1] > 1:
                        return False 
        return True
