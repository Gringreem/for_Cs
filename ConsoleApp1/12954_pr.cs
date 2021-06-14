using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution_12954
{
    public long[] solution(int x, int n)
    {
        long[] answer = new long[n];
        long a = x;

        for(int i = 0; i < n; i++)
        {
            answer[i] = a + i * a;
        }

        return answer;
    }
}