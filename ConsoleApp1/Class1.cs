using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
    public int[,] solution(int[,] arr1, int[,] arr2)
    {
        int[,] answer = new int[arr1.GetLength(0), arr2.GetLength(1)];

        for(int i =0; i < arr1.GetLength(0); i++)
        {
            for(int j = 0; j < arr1.GetLength(1); j++)
            {
                int sum = 0;
                for(int k = 0; k < arr2.GetLength(0); k++)
                {
                    sum += arr1[i,j] * arr2[j,k];
                }
                answer[i, j] = sum;
            }
        }


        return answer;
    }
}