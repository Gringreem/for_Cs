using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Solution_12945
{
    public int solution(int n)
    {
        int[] answer = new int[n+1];
        answer[0] = 0;
        answer[1] = 1;
        for(int i = 2; i < n + 1; i++)
        {
            answer[i] = answer[i - 1] % 1234567 + answer[i - 2] % 1234567;
        }

        return answer[n] % 1234567;
    }
}