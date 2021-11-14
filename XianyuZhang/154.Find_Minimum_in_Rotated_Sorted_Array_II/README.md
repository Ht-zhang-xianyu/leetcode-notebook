### [154. 寻找旋转排序数组中的最小值 II](https://leetcode-cn.com/problems/find-minimum-in-rotated-sorted-array-ii/)

#### Description

题目可能存在重复，将数组进行旋转，得到对应的最小元素的值

```python
输入：nums = [2,2,2,0,1]
输出：0

输入：nums = [1,3,5]
输出：1
```



#### Solution

多参照的是这个[题解](https://leetcode-cn.com/problems/xuan-zhuan-shu-zu-de-zui-xiao-shu-zi-lcof/solution/mian-shi-ti-11-xuan-zhuan-shu-zu-de-zui-xiao-shu-3/)

总体思想是二分，每次讲中间元素`mid`跟数组的`right`进行比对，从而确认当前这个`mid`是在左边的升序中还是右边的升序，即有如下三种情况的划分：

1、当数组的`mid` 大于`right`时，可以判定，这会中间元素在左边的升序列表中，此时`left=mid + 1`

2、当`mid`小于`right`，可以判定，这会中间元素在右边的升序列表中，此时`right = mid `

3、当两个相等时，可能是遇到了重复的元素， 此时可以`right -= 1`用以控制范围

上述题解解释到为什么不用`left`作为比较的锚点，是由于， 当中间的元素跟左边的元素进行比较时，会出现无法判断其是在左边的升序排序序列还是在右边的升序排序的右边序列中，故而选择了右边的元素作为了锚点。



#### Code

```python
class Solution(object):
    def minArray(self, nums):
        """
        :type numbers: List[int]
        :rtype: int
        """
        left, right = 0, len(nums) - 1 
        while left <= right:
            mid = (left + right) // 2
            if nums[mid] > nums[right]:
                left = mid + 1 
            elif nums[mid] < nums[right]:
                right = mid 
            else:
                right-=1
        return nums[left]
```

