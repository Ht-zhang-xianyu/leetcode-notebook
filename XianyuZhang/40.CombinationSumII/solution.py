class Solution(object):
    def combinationSum2(self, candidates, target):
        """
        :type candidates: List[int]
        :type target: int
        :rtype: List[List[int]]
        """
        res = list()
        # 由于要求相应的没有重复，所以需要排序一下，方便驱虫
        candidates = sorted(candidates)

        def backTracking(candidates, tmp_res, start):
            # 当组合和大于目标时，跳过
            if sum(tmp_res) > target:
                return 
            # 当组合等于目标且没有重复时，添加
            if sum(tmp_res) == target and tmp_res not in res:
                res.append(tmp_res[:])
                return 
            for i in range(start, len(candidates)):
                # 剪枝，用以剪掉同级的重复元素
                if i > start and candidates[i] == candidates[i-1]:
                    continue 
                tmp_res.append(candidates[i])
                backTracking(candidates, tmp_res, i+1)
                tmp_res.pop()
        backTracking(candidates, [], 0)
        return res 
