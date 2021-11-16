### [415. 字符串相加](https://leetcode-cn.com/problems/add-strings/)

#### Description

给定数字字符串，计算和并以字符串形式返回

```python
输入：num1 = "11", num2 = "123"
输出："134"

输入：num1 = "456", num2 = "77"
输出："533"
```



#### Solution

可以使用`while`循环，分别有两个指针，当作下标的索引，当其大于等于0时，两个指针向前计算，每次前向计算时，对应的下标索引-1，保留的数字，一个一个往`res`的最前面进行添加



#### Code 

```python
class Solution(object):
    def addStrings(self, num1, num2):
        """
        :type num1: str
        :type num2: str
        :rtype: str
        """
        res = ''
        i, j, add = len(num1)-1, len(num2)-1, 0
        while i >= 0 or j >= 0:
            if i >= 0:
                n1 = int(num1[i])
            else:
                n1 = 0
            if j >= 0:
                n2 = int(num2[j])
            else:
                n2 = 0
            tmp = n1 + n2 + add 
            add = tmp // 10 
            res = str(tmp % 10) + res 
            i -= 1 
            j -= 1 
        if add:
            res = '1' + res 
        return res 
```

