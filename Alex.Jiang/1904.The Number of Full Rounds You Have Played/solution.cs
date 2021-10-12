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