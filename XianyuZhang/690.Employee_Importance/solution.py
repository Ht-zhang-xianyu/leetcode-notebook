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
