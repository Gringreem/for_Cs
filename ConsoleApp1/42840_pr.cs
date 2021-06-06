using System;
using System.Collections.Generic;

public class Solution_42840{
    public int[] solution(int[] answers){


        List<int> answer = new List<int>();

        int[] first = new int[] { 1, 2, 3, 4, 5 };
        int[] second = new int[] { 2, 1, 2, 3, 2, 4, 2, 5 };
        int[] third = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

        int[] count = new int[3];

        for(int i =0; i < answers.Length; i++)
        {
            if (first[i%5] == answers[i]) count[0]++;
            if (second[i%8] == answers[i]) count[1]++;
            if (third[i%10] == answers[i]) count[2]++;
        }

        int max = 0;

        for(int i = 0; i < 3; i++)
        {
            if (max < count[i])
            {
                max = count[i];
            }
        }

        for(int i = 0; i < 3; i++)
        {
            if(max == count[i])
            {
                answer.Add(i+1);
            }
        }



        return answer.ToArray();
    }
}