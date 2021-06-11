using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution_12943
{
    public int solution(int num)
    {
        int answer = 0;

        while (true)
        {
            if(num == 1)
            {
                answer = 0;
                break;
            }
            if(num%2 == 0)
            {
                num = num / 2;
            }
            else
            {
                num = (num * 3) + 1;
            }
            if (answer++ >= 450)
            {
                answer = -1;
                break;
            }
            if (num == 1)
            {
                break;
            }
            
        }

        return answer;
    }
}