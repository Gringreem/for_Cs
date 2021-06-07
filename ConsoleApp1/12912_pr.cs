using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution_12912
{
    public long solution(int a, int b)
    {
        long answer = 0;

        if (a < b)
        {
            for (int i = a; i <= b; i++)
            {
                answer += i;
            }

        }
        else
        {
            for (int i = b; i <= a; i++)
            {
                answer += i;
            }
        }
        

        return answer;
    }
}