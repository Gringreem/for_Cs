using System;
using System.Linq;
using System.Collections.Generic;


public class Solution_77484
{
    public int[] solution(int[] lottos, int[] win_nums)
    {
        List<int> answer = new List<int>();
        int count = 0;
        int zero = 0;

        for(int i = 0; i < lottos.Length; i++)
        {
            if (lottos[i] == 0)
            {
                zero++;
            }
            if (lottos.Contains(win_nums[i])){
                count++;
            }
        }
        
        if ((count + zero) < 2) answer.Add(6);
        else answer.Add(7 - count - zero);

        if (count < 2) answer.Add(6);
        else answer.Add(7 - count);

        
        return answer.ToArray();
    }
}