### [36. 有效的数独](https://leetcode-cn.com/problems/valid-sudoku/)

#### Description

给定了已经写好数字的数字，判断说，填好的数字是否能构成一个有效的数独



#### Solution

根据题目的提示，构建3个矩阵，分别用以计算行，列，以及小模块，如下

```python
# 基于行的矩阵
# 每行9个数，当出现一个数字时，在对应的下标 +1
[1, 2, 3, ...]
# 对于 每个小块，也是同样用列表进行计数，然后有9个这样的模块对应3*3
# 可以按如下写
[[[0] * 9 for _ in range(3)] for _ in range(3)]
```

当构建完如上的计数矩阵后，只需要遍历整个数独，然后对遇到的数字，如果存在就+1，当超过1时，就返回False就好了



#### Code

```python
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
```

