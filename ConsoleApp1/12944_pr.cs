using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution_12944
{
    public double solution(int[] arr)
    {
        double answer = 0;

        for(int i = 0; i < arr.Length; i++)
        {
            answer += arr[i];
        }
        
        return answer/arr.Length;
    }
}