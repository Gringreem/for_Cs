using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution_12910
{
    public int[] solution(int[] arr, int divisor)
    {
        List<int> answer = new List<int>();
        int count = 0;

        for(int i=0;i<arr.Length; i++)
        {
            if(arr[i] % divisor == 0)
            {
                answer.Add(arr[i]);
                count++;
            }
        }
        if(count == 0)
        {
            answer.Add(-1);
        }
        answer.Sort();

        return answer.ToArray();
    }
}