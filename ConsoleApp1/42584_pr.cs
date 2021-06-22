using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution_42584
{
    public int[] solution(int[] prices)
    {
        int[] answer = new int[prices.Length];

        for(int i=0; i < answer.Length; i++)
        {
            for(int j=i+1; j < answer.Length; j++)
            {
                if (prices[i] > prices[j])
                {
                    answer[i] = j - i;
                    break;
                }
                if (j == answer.Length - 1)
                {
                    answer[i] = j - i;
                }
            }
        
        }
        
        return answer;
    }
}