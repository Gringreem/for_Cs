using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution_12928
{
    public int solution(int n)
    {
        int answer = 0;

        for(int i = 1; i <= n; i++)
        {
            if(n%i == 0)
            {
                answer += i;
            }
        }

        return answer;
    }
}