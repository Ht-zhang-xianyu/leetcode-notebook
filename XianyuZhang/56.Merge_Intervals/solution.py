class Solution(object):
    def merge(self, intervals):
        """
        :type intervals: List[List[int]]
        :rtype: List[List[int]]
        """
        # 根据第一位的元素进行排序
        intervals = sorted(intervals, key=lambda x:x[0])
        res = list()
        for i, num in enumerate(intervals):
            # 处理第一个元素 
            # 比较新元素的第一位跟已经添加元素的第二位
            if not res or res[-1][1] < num[0]:
                res.append(num)
            else:
                # 更新已经添加数组的第二位
                res[-1][1] = max(res[-1][1], num[1])
        return res 
