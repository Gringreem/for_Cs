using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution_12935
{
    public int[] solution(int[] arr)
    {
        int num = arr.Min();
        int[] answer = arr.Where(x => x != num).ToArray();

        if(answer.Count() == 0)
        {
            answer = new int[] { -1 };
        }

        return answer;
    }
}