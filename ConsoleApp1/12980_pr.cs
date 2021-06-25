using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution_12980
{
    public int solution(int n)
    {
        int answer = 0;

        while (n > 0)
        {
            if (n % 2 == 1)
            {
                answer++;
            }
            n /= 2;
        }

        return answer;
    }
}