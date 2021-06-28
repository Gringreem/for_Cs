using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution_12949
{
    public int[,] solution(int[,] arr1, int[,] arr2)
    {
        int[,] answer = new int[arr1.GetLength(0), arr2.GetLength(1)];

        for(int i =0; i < arr1.GetLength(0); i++)
        {
            for(int j = 0; j < arr2.GetLength(1); j++)
            {
                int sum = 0;
                
                for(int a = 0; a < arr1.GetLength(1); a++)
                {
                    sum += arr1[i, a] * arr2[a, j];
                }
                
                answer[i, j] = sum;
            }
        }

        return answer;
    }
}