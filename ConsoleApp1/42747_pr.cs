using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Solution_42747
{
    public int solution(int[] citations)
    {
        int answer = 0;
        Array.Sort(citations);

        for(int H = citations.Max(); H > 0; H--)
        {
            int k = citations.Count(x => x >= H);

            if (k >= H)
            {
                answer = H;
                break;
            }
        }


        return answer;
    }
}