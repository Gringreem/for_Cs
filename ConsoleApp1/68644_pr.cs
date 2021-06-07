using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution_68644
{
    public int[] solution(int[] numbers)
    {
        List<int> answer = new List<int>();
        List<int> newNum = numbers.ToList();
        newNum.Sort();

        for(int i=0; i<newNum.Count; i++)
        {
            for(int j=i+1; j<newNum.Count; j++)
            {
                if(answer.Contains(newNum[i] + newNum[j]))
                {
                    continue;
                }
                answer.Add(newNum[i] + newNum[j]);
            }
        }

        answer.Sort();

        return answer.ToArray();
    }
}