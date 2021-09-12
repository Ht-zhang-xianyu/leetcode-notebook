### [678. 有效的括号字符串](https://leetcode-cn.com/problems/valid-parenthesis-string/)

#### Description

不仅只有括号，还有星号，判断该字符串是否合理

```python
example1:
输入: "()"
输出: True

example2:
输入: "(*)"
输出: True
  
example3:
输入: "(*))"
输出: True
```



#### Solution

用两个栈存储，一个存储星号的下标，一个存储左括号的下标

因为星号可以当作是左括号和右括号，所以当遇到右括号时，我们优先弹出左括号栈的元素，再弹出星号栈的元素，如果没有就结束，返回False

到最后循环完时，我们可以根据先前进栈的下标，再查看左括号右边是否有星号进行匹配，如果没有就返回False



Code

```python
class Solution:
    def checkValidString(self, s: str) -> bool:
        if not s:
            return True 
        # 用两个栈来存储下标
        leftStack, starStack = list(), list()
        for i,string in enumerate(s):
            if string == '(':
                leftStack.append(i)
            elif string == '*':
                starStack.append(i)
            # 当遇到右括号，先弹出来左括号，如果没有弹星号
            # 不然就返回False
            elif string == ')':
                if leftStack:
                    leftStack.pop()
                elif starStack:
                    starStack.pop()
                else:
                    return False 
        print(leftStack)
        print(starStack)
        if len(leftStack) > len(starStack):
            return False 
        while leftStack and starStack:
            if not starStack:
                return False 
            # 当左括号的下标，大于最后一个星号时
            # 即是没有匹配上，返回False
            leftIndex = leftStack.pop()
            startIndex = starStack.pop()
            if leftIndex > startIndex:
                return False 
        return True  
```

