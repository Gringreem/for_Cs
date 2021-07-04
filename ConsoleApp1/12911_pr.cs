using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Solution
{
    public int solution(int n)
    {
        int answer = 0;

        if(n%2 == 0)
        {
            n += 1;
            int bit = 1;
            while (true)
            {
                if((n & bit) == 0)
                {
                    break;
                }
                bit *= 2;
            }
            bit /= 4;
            answer = n + bit;

        }
        else
        {
            int bit = 1;
            while (true)
            {
                if((n & bit) == 0)
                {
                    break;
                }
                bit *= 2;
            }
            bit /= 2;
            answer = n + bit;
        }

        return answer;
    }
}