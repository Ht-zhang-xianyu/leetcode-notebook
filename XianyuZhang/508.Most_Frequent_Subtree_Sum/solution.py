class Solution(object):
    def findFrequentTreeSum(self, root):
        """
        :type root: TreeNode
        :rtype: List[int]
        """
        if not root:
            return None 
        # 用一个列表用于保存遍历结果
        self.res = list()
        _ = self.helper(root)
        count_dict = {}
        # 计数 
        for i, num in enumerate(self.res):
            if num not in count_dict:
                count_dict[num] = 0
            count_dict[num] += 1
        # 返回一样的元素
        sorted_hash = sorted(count_dict.items(), key=lambda x:x[1], reverse=True)
        res = [sorted_hash[i][0] for i in range(len(sorted_hash)) if sorted_hash[i][1]==sorted_hash[0][1]]
        return res 
    
    def helper(self, root):
        if not root:
            return 0
        left_value = self.helper(root.left)
        right_value = self.helper(root.right)
        # 后序遍历，将从叶子节点的值往上层加
        root.val = root.val + left_value + right_value
        # 保存每个节点的值，用于后续的计数
        self.res.append(root.val)
        return root.val
