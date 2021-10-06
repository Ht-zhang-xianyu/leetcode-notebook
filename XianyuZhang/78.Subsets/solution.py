class Solution(object):
    def subsets(self, nums):
        """
        :type nums: List[int]
        :rtype: List[List[int]]
        """
        if not nums:
            return []
        res = []
        def backTracking(nums, start, temp):
            #  其实我这里不是太懂 为什么直接append temp会是一个一个空值
            #  这里限制，可以不用 if  break
            res.append(temp[:])
            for i in range(start, len(nums)): 
                # 添加每个数，然后将对应的数值弹出
                temp.append(nums[i])
                backTracking(nums, i+1, temp)
                temp.pop()
        backTracking(nums, 0, [])
        return res
