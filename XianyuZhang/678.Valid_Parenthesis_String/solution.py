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
