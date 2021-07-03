using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution_42586
{
    public int[] solution(int[] progresses, int[] speeds)
    {
        List<int> answer = new List<int>();
        int[] count = new int[progresses.Length];

        for(int i = 0; i < progresses.Length; i++)
        {
            double check = (100 - progresses[i]) / (double)speeds[i];
            count[i] = (int)Math.Ceiling(check);
        }
        
        int prev = count[0];
        int num = 1;

        for(int i = 1; i < count.Length; i++)
        {
            if(prev >= count[i])
            {
                num++;
            }
            else
            {
                prev = count[i];
                answer.Add(num);
                num = 1;
            }
        }
        answer.Add(num);

        return answer.ToArray();
    }
}