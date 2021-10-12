## 1904. The Number of Full Rounds You Have Played

A new online video game has been released, and in this video game, there are **15-minute** rounds scheduled every **quarter-hour** period. This means that at `HH:00`, `HH:15`, `HH:30` and `HH:45`, a new round starts, where `HH` represents an integer number from `00` to `23`. A **24-hour clock** is used, so the earliest time in the day is `00:00` and the latest is `23:59`.

Given two strings `startTime` and `finishTime` in the format `"HH:MM"` representing the exact time you **started** and **finished** playing the game, respectively, calculate the **number of full rounds** that you played during your game session.

- For example, if `startTime = "05:20"` and `finishTime = "05:59"` this means you played only one full round from `05:30` to `05:45`. You did not play the full round from `05:15` to `05:30` because you started after the round began, and you did not play the full round from `05:45` to `06:00` because you stopped before the round ended.

If `finishTime` is **earlier** than `startTime`, this means you have played overnight (from `startTime` to the midnight and from midnight to `finishTime`).

Return *the **number of full rounds** that you have played if you had started playing at* `startTime` *and finished at* `finishTime`.

 

**Example 1:**

```
Input: startTime = "12:01", finishTime = "12:44"
Output: 1
Explanation: You played one full round from 12:15 to 12:30.
You did not play the full round from 12:00 to 12:15 because you started playing at 12:01 after it began.
You did not play the full round from 12:30 to 12:45 because you stopped playing at 12:44 before it ended.
```

**Example 2:**

```
Input: startTime = "20:00", finishTime = "06:00"
Output: 40
Explanation: You played 16 full rounds from 20:00 to 00:00 and 24 full rounds from 00:00 to 06:00.
16 + 24 = 40.
```

**Example 3:**

```
Input: startTime = "00:00", finishTime = "23:59"
Output: 95
Explanation: You played 4 full rounds each hour except for the last hour where you played 3 full rounds.
```

 

**Constraints:**

- `startTime` and `finishTime` are in the format `HH:MM`.
- `00 <= HH <= 23`
- `00 <= MM <= 59`
- `startTime` and `finishTime` are not equal.



## 解题思路

这个实际时间分别是A:B 与 C:D，先设想成求A:00 到C:00的结果，然后对于A:B 与A:00的差值，对总结果做减法，对于C:D 到 C:00的结果，求加法，就是结果集。

左侧如果是15，一类的边界值，结果集是B /15 如果不是的话，实际上是B/15 +1 的

右侧就比较简单，00是边界值，所以直接用D/15 就可以了

结果集公式就是 （C-A）* 4 - left + right

这是个伪公式，还要考虑第二天的场景。

Code

```c#
public class Solution {
    public int NumberOfRounds(string startTime, string finishTime) {
        string[] leftTime = startTime.Split(':');
        string[] rightTime = finishTime.Split(':');
        int leftHour = int.Parse(leftTime[0]);
        int leftMinu = int.Parse(leftTime[1]);
        int rightHour = int.Parse(rightTime[0]);
        int rightMinu = int.Parse(rightTime[1]);
        
        if(rightHour < leftHour || (rightHour == leftHour && leftMinu > rightMinu))
           rightHour += 24;
        
        int tmp = rightHour-leftHour;
        int left = leftMinu % 15 == 0 ? leftMinu / 15 : (leftMinu / 15 + 1);
        int result = tmp * 4 -left + rightMinu / 15;
        return result > 0?result:0; 
        
    }
}
```



