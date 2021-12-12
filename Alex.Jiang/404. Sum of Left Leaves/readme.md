# 404. Sum of Left Leaves

- Given the `root` of a binary tree, return the sum of all left leaves.

   

  **Example 1:**

  ![img](https://assets.leetcode.com/uploads/2021/04/08/leftsum-tree.jpg)

  ```
  Input: root = [3,9,20,null,null,15,7]
  Output: 24
  Explanation: There are two left leaves in the binary tree, with values 9 and 15 respectively.
  ```

  **Example 2:**

  ```
  Input: root = [1]
  Output: 0
  ```

   

  **Constraints:**

  - The number of nodes in the tree is in the range `[1, 1000]`.
  - `-1000 <= Node.val <= 1000`





## 解题思路

DFS的思路，深度递归，这里取巧，因为要判断的是所有的左叶子节点，这里并没有判断，只是通过将右结点的value设置成0 的方式，让其参与计算之后，结果一样。然后递归所有的左右节点就可以了。



Discuss里面，有人通过flag的方式做的标记，函数是 DFS(TreeNode node, bool flag) 也可以。 







