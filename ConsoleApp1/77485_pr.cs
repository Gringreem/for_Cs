using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution_77485
{
    public int[] solution(int rows, int columns, int[,] queries)
    {
        List<int> answer = new List<int>();
        int count = queries.GetLength(0);

        int[,] map = new int[rows, columns];
        int first = 1;

        for(int i = 0; i<rows; i++)
        {
            for(int j = 0; j<columns; j++)
            {
                map[i, j] = first++;
            }
        }


        for(int i=0; i<count; i++)
        {
            int[] query = new int[4];
            query[0] = queries[i, 0];
            query[1] = queries[i, 1];
            query[2] = queries[i, 2];
            query[3] = queries[i, 3];
            answer.Add(rotate(map, query));
        }

        return answer.ToArray();
    }

    private int rotate(int[,] map, int[] query)
    {
        int n = map[query[0] - 1, query[3] - 1];
        int min = n;
        for(int i = query[3] -1; i>=query[1]; i--)
        {
            min = Math.Min(min, map[query[0] - 1, i - 1]);
            map[query[0] - 1, i] = map[query[0] - 1, i - 1];
        }
        for (int i = query[0]; i < query[2]; i++)
        {
            min = Math.Min(min, map[i, query[1]-1]);
            map[i - 1, query[1]-1] = map[i, query[1] - 1];
        }
        for (int i = query[1]; i < query[3]; i++)
        {
            min = Math.Min(min, map[query[2] - 1, i]);
            map[query[2] - 1, i-1] = map[query[2] - 1, i];
        }
        for (int i = query[2] - 1; i >= query[0]; i--)
        {
            min = Math.Min(min, map[i-1, query[3] - 1]);
            map[i,query[3]-1] = map[i - 1, query[3] - 1];
        }

        map[query[0], query[3] - 1] = n;
        return min;
    }
}