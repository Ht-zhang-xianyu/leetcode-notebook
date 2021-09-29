class Solution(object):
    def combine(self, n, k):
        """
        :type n: int
        :type k: int
        :rtype: List[List[int]]
        """
        # 创建 结果的收纳列表
        res, temp = list(), list()

        def backTracking(n, k, start):
            # 当满足条件时，将当前的列表推进结果列表，返回
            if len(temp) == k:
                res.append(temp[:])
                return 
            for i in range(start, n):
                # 每次推进一个列表
                temp.append(i)
                # 树的遍历
                backTracking(n, k, i+1)
                # 回到上个节点
                temp.pop()
        backTracking(n+1, k, 1)
        return res
