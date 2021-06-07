using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution_12982
{
    public int solution(int[] d, int budget)
    {
        int answer = 0;
        List<int> newD = d.ToList();
        newD.Sort();

        for(int i = 0; i < d.Length; i++)
        {
            if(newD[i] <= budget)
            {
                budget -= newD[i];
                answer++;
            }
            else
            {
                break;
            }
        }

        return answer;
    }
}
