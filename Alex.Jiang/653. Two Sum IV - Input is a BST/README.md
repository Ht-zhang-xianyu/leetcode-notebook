# 653. Two Sum IV - Input is a BST

Given the `root` of a Binary Search Tree and a target number `k`, return *`true` if there exist two elements in the BST such that their sum is equal to the given target*.

 

**Example 1:**

![img](https://assets.leetcode.com/uploads/2020/09/21/sum_tree_1.jpg)

```
Input: root = [5,3,6,2,4,null,7], k = 9
Output: true
```

**Example 2:**

![img](https://assets.leetcode.com/uploads/2020/09/21/sum_tree_2.jpg)

```
Input: root = [5,3,6,2,4,null,7], k = 28
Output: false
```

**Example 3:**

```
Input: root = [2,1,3], k = 4
Output: true
```

**Example 4:**

```
Input: root = [2,1,3], k = 1
Output: false
```

**Example 5:**

```
Input: root = [2,1,3], k = 3
Output: true
```

 

**Constraints:**

- The number of nodes in the tree is in the range `[1, 104]`.
- `-104 <= Node.val <= 104`
- `root` is guaranteed to be a **valid** binary search tree.
- `-105 <= k <= 105`



利用一个HashSet， 每次求解的时候，如果没有target 就把自己放到set集合里面，全部遍历一遍之后，如果都没有找到，就一定是没了。由于是全部遍历，不需要逐个找对应的pair， 比如说有5和4，当5先遍历的时候，没有4，所以返回false，但是当遍历到4的时候，其实5在set集合里面，所以肯定可以找到。

