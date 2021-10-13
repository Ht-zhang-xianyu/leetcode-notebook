class Solution(object):
    def combinationSum(self, candidates, target):
        """
        :type candidates: List[int]
        :type target: int
        :rtype: List[List[int]]
        """
        res = list()
        def backTracking(candidates, start, tmp_res):
            # 如果超了 就砍掉
            if sum(tmp_res) > target:
                return 
            # 如果等于就添加
            if sum(tmp_res) == target:
                res.append(tmp_res[:])
                return 
            # 回溯的过程
            for i in range(start, len(candidates)):
                tmp_res.append(candidates[i])
                backTracking(candidates, i, tmp_res)
                tmp_res.pop()
        backTracking(candidates, 0, [])
        return res 
