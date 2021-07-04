using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution_68645
{
    public int[] solution(int n)
    {
        List<int> answer = new List<int>();
        int[,] temp = new int[n, n];

        int x = -1, y = 0;
        int num = 1;
        
        for(int i = 0; i < n; i++)
        {
            for(int j = i; j < n; j++)
            {
                if(i%3 == 0)
                {
                    x++;
                }
                else if(i%3 == 1)
                {
                    y++;
                }
                else
                {
                    x--;
                    y--;
                }
                temp[x, y] = num++;
            }
        }

        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if(temp[i,j] == 0)
                {
                    break;
                }
                answer.Add(temp[i, j]);
            }
        }


        return answer.ToArray();
    }
}