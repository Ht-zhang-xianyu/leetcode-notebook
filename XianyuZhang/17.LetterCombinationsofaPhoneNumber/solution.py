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
