### [690. 员工的重要性](https://leetcode-cn.com/problems/employee-importance/)

#### Description 

给定一个列表，其中员工之间存在着上下级的关系，根据其每个人的分数以及其下级的关系，计算其重要程度

exp

```shell
输入：[[1, 5, [2, 3]], [2, 3, []], [3, 3, []]], 1
输出：11
解释：
员工 1 自身的重要度是 5 ，他有两个直系下属 2 和 3 ，而且 2 和 3 的重要度均为 3 。因此员工 1 的总重要度是 5 + 3 + 3 = 11 。
```



#### Solution

基于深度优先的解法，每看到一个人，就计算那个人的分数以及下属的分数。

前面需要有一个字典来存储不同的id跟不同的员工之间的关系，有一点点的绕弯



#### Code

```python
class Solution(object):
    def getImportance(self, employees, id):
        """
        :type employees: List[Employee]
        :type id: int
        :rtype: int
        """
        empList = {employe.id : employe for employe in employees}

        def dfs(id):
            emp = empList[id]
            res = emp.importance
            for tmp in emp.subordinates:
                res += dfs(tmp)
            return res 

        res = dfs(id)
        return res 
```

