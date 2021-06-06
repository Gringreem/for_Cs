using System;

public class Solution_76501
{
    public int solution(int[] absolutes, bool[] signs)
    {
        int answer = 0;

        for (int i = 0; i < absolutes.Length; i++)
        {
            if (signs[i] == true)
            {
                answer += absolutes[i];
            }
            else
            {
                answer -= absolutes[i];
            }
        }

        return answer;
    }
}