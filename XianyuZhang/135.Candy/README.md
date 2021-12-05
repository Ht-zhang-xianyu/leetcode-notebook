### [135. 分发糖果](https://leetcode-cn.com/problems/candy/)

#### Description

有N个小孩，有如下要求，每个小孩至少一个糖果，两侧如果有小孩评分比他高的话，糖果数目需要比他多，求最少需要多少糖果

```python
输入：[1,0,2]
输出：5
解释：你可以分别给这三个孩子分发 2、1、2 颗糖果。
```



#### Solution

可以设置两个数组，`left_tmp`和`right_tmp`分别表示：

左边的小朋友比当前小朋友评分高时的情况

右边的小朋友比当前小朋友评分高的情况

最后循序每个位置两个数组取`max`就可以了



#### Code

```python
class Solution(object):
    def candy(self, ratings):
        """
        :type ratings: List[int]
        :rtype: int
        """
        left_tmp = [1 for _ in range(len(ratings))]
        right_tmp = [1 for _ in range(len(ratings))]
        n, res = len(ratings), 0
        for i in range(1, n):
            if ratings[i] > ratings[i-1]:
                left_tmp[i] = left_tmp[i-1]+1
        for i in range(n-2, -1, -1):
            if ratings[i] > ratings[i+1]:
                right_tmp[i] = right_tmp[i+1] + 1
        for i in range(n):
            res += max(right_tmp[i], left_tmp[i])
        return res 
```

