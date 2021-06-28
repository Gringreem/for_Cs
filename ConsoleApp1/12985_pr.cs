using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Solution_12985
{
    public int solution(int n, int a, int b)
    {
        int answer = 0;

        double first = a;
        double second = b;
        int count = 1;

        while (n > 0)
        {
            if (Math.Ceiling(first / 2) == Math.Ceiling(second / 2))
            {
                answer = count;
                break;
            }
            else
            {
                first = Math.Ceiling(first / 2);
                second = Math.Ceiling(second / 2);
                count++;
                n /= 2;
            }
        }
        
        return answer;
    }
}