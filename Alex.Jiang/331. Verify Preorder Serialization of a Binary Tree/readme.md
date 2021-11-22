# 331. Verify Preorder Serialization of a Binary Tree

One way to serialize a binary tree is to use **preorder traversal**. When we encounter a non-null node, we record the node's value. If it is a null node, we record using a sentinel value such as `'#'`.

![img](https://assets.leetcode.com/uploads/2021/03/12/pre-tree.jpg)

For example, the above binary tree can be serialized to the string `"9,3,4,#,#,1,#,#,2,#,6,#,#"`, where `'#'` represents a null node.

Given a string of comma-separated values `preorder`, return `true` if it is a correct preorder traversal serialization of a binary tree.

It is **guaranteed** that each comma-separated value in the string must be either an integer or a character `'#'` representing null pointer.

You may assume that the input format is always valid.

- For example, it could never contain two consecutive commas, such as `"1,,3"`.

**Note:** You are not allowed to reconstruct the tree.

 

**Example 1:**

```
Input: preorder = "9,3,4,#,#,1,#,#,2,#,6,#,#"
Output: true
```

**Example 2:**

```
Input: preorder = "1,#"
Output: false
```

**Example 3:**

```
Input: preorder = "9,#,#,1"
Output: false
```

 

**Constraints:**

- `1 <= preorder.length <= 104`
- `preorder` consist of integers in the range `[0, 100]` and `'#'` separated by commas `','`.





## 解题思路

这里的思路是，从头开始遍历，当没有值得时候，其实是有一个root连接节点得，所以flag = 1, 每插入一个节点，flag要减少一个值，而如果传进来得是数字，那会额外增加两个连接节点，就+2，如果是#表示为null，不会在产生节点，就不增加值了。过程中如果发现flag < 0 则表示当前时刻没有地方增加额外的节点，就不满足题解条件。

最后的判断就是全部挂满，flag == 0





