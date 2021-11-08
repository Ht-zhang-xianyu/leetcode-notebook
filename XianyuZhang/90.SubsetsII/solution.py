class Solution(object):
    def subsetsWithDup(self, nums):
        """
        :type nums: List[int]
        :rtype: List[List[int]]
        """
        res, tmp_res = list(), list()
        nums = sorted(nums)
        def backTracking(nums, start):
            res.append(tmp_res[:])
            for i in range(start, len(nums)):
                if i > start and nums[i] == nums[i-1]:
                    continue 
                tmp_res.append(nums[i])
                backTracking(nums, i+1)
                tmp_res.pop()
        backTracking(nums, 0)
        return res 
