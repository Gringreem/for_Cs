using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Solution_49189
{
    public int solution(int n, int[,] edge)
    {
        int[] distance = new int[n + 1];
        bool[,] map = new bool[n + 1, n + 1];

        for(int i = 0; i < edge.GetLength(0); i++)
        {
            map[edge[i, 0], edge[i, 1]] = map[edge[i, 1], edge[i, 0]] = true;
        }

        List<int> nodes = new List<int>();
        nodes.Add(1);

        int top = 0;

        int max = 0;
        while (top>=0)
        {
            int i = nodes[top--];

            for(int j = 2; j <= n; j++)
            {
                if(distance[j] == 0 && map[i, j])
                {
                    distance[j] = distance[i] + 1;
                    nodes.Add(j);
                    top++;
                    max = Math.Max(max, distance[j]);
                }
            }
        }

        int answer = 0;
        foreach(int d in distance)
        {
            if (max == d) answer++;
        }

        return answer;
    }
}