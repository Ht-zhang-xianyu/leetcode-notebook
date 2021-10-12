class Solution(object):
    def permute(self, nums):
        """
        :type nums: List[int]
        :rtype: List[List[int]]
        """
        res = list()

        def backTracking(nums, tmp):
            # 终止条件
            if len(tmp) == len(nums):
                res.append(tmp[:])
                return 
            for i, num in enumerate(nums):
                # 由于是顺序遍历，所以去除掉前面的已经添加的部分
                if num in tmp:
                    continue 
                # 路径选择
                tmp.append(num)
                # 回溯
                backTracking(nums, tmp)
                # 回退到父节点
                tmp.pop()
        backTracking(nums, [])
        return res 
