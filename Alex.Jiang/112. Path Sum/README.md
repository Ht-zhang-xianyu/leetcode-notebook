## 112. Path Sum

- Given the `root` of a binary tree and an integer `targetSum`, return `true` if the tree has a **root-to-leaf** path such that adding up all the values along the path equals `targetSum`.

  A **leaf** is a node with no children.

   

  **Example 1:**

  ![img](https://assets.leetcode.com/uploads/2021/01/18/pathsum1.jpg)

  ```
  Input: root = [5,4,8,11,null,13,4,7,2,null,null,null,1], targetSum = 22
  Output: true
  ```

  **Example 2:**

  ![img](https://assets.leetcode.com/uploads/2021/01/18/pathsum2.jpg)

  ```
  Input: root = [1,2,3], targetSum = 5
  Output: false
  ```

  **Example 3:**

  ```
  Input: root = [1,2], targetSum = 0
  Output: false
  ```

   

  **Constraints:**

  - The number of nodes in the tree is in the range `[0, 5000]`.
  - `-1000 <= Node.val <= 1000`
  - `-1000 <= targetSum <= 1000`



## 解题思路



深度递归，退出条件是如果当前节点为null，则此线路不存在，如果左右节点都是null，并且当前节点得值加上之前总和等于target 就对了。否则递归左右两侧，条件为或条件。



