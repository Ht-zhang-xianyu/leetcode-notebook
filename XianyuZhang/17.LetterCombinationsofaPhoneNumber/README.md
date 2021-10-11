### [17. 电话号码的字母组合](https://leetcode-cn.com/problems/letter-combinations-of-a-phone-number/)

#### Description

给定电话号码的数字(`2-9`)和字母的映射，返回可能的字母组合

```python
输入：digits = "23"
输出：["ad","ae","af","bd","be","bf","cd","ce","cf"]
```



#### Solution

可以一开始设定一个数字和字母之间的映射表，然后用`index`变量控制在数字之间的走向，每经历一个数字，就回溯取遍该数字的所有字母，遍历到最后，就可以得到所有的字母了



#### Code

```python
class Solution(object):
    def letterCombinations(self, digits):
        """
        :type digits: str
        :rtype: List[str]
        """
        if not digits:
            return []
        digitMap = {'2': 'abc', '3':'def', '4':'ghi', '5':'jkl',
                    '6':'mno', '7':'pqrs', '8':'tuv', '9':'wxyz'}
        res = list()
        def backTracking(digits, tmp_res, digStart):
            # 当tmp_res等于给到的数字时，就添加
            if len(tmp_res) == len(digits):
                res.append(tmp_res[:])
                return 
            # 第一层的循环用以控制 不要重复
            for i in range(digStart, len(digits)):
                for j in range(len(digitMap[digits[i]])):
                    # print(tmp_res)
                    tmp_res += digitMap[digits[i]][j]
                    backTracking(digits, tmp_res, i+1)
                    tmp_res = tmp_res[:-1]
        backTracking(digits, '',  0)
        return res 
```



#### Link

| 题目                                                         | 难度    |
| ------------------------------------------------------------ | ------- |
| [17 电话号码的字母组合](https://leetcode-cn.com/problems/letter-combinations-of-a-phone-number/) | **Mid** |
| [46. 全排列](https://leetcode-cn.com/problems/permutations/) | **Mid** |
| [组合总和3](https://leetcode-cn.com/problems/combination-sum-iii/submissions/) | **Mid** |
| [77 组合](https://leetcode-cn.com/problems/combinations/)    | **Mid** |
| [78 子集](https://leetcode-cn.com/problems/subsets/)         | **Mid** |

