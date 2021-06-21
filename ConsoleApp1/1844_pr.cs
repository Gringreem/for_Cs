using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Solution_1844
{
    public int solution(int[,] maps)
    {
        int answer = 0;

        int x = maps.GetLength(0);
        int y = maps.GetLength(1);
        int max = x * y;
        if (max == 2) return max;
        rowCnt.Clear();
        columnCnt.Clear();

        find_path(x - 1, y - 1, maps, 1);

        for(int i = 2; i < max; i++)
        {
            if(rowCnt.Count == 0)
            {
                answer = -1;
                i = max;
            }
            else
            {

                for(int j = rowCnt.Count - 1; j >= 0; j--)
                {
                    if (rowCnt[j] > 0 && maps[rowCnt[j] - 1, columnCnt[j]] == 1) find_path(rowCnt[j] - 1, columnCnt[j], maps, i);
                    if (rowCnt[j] < x-1 && maps[rowCnt[j] + 1, columnCnt[j]] == 1) find_path(rowCnt[j] + 1, columnCnt[j], maps, i);
                    if (columnCnt[j] > 0 && maps[rowCnt[j], columnCnt[j] - 1] == 1) find_path(rowCnt[j], columnCnt[j] - 1, maps, i);
                    if (columnCnt[j] < y-1 && maps[rowCnt[j], columnCnt[j] + 1] == 1) find_path(rowCnt[j], columnCnt[j] + 1, maps, i);
                    rowCnt.RemoveAt(j);
                    columnCnt.RemoveAt(j);
                }
                for(int j = 0; j < rowCnt.Count; j++)
                {
                    if((rowCnt[j] == 0 && columnCnt[j] == 1) || (rowCnt[j] == 1 && columnCnt[j] == 0))
                    {
                        answer = i + 1;
                        j = rowCnt.Count - 1;
                        i = max - 1;
                    }
                }
            }
        }

        if (answer == 0) answer = -1;
        return answer;
    }
    List<int> rowCnt = new List<int>();
    List<int> columnCnt = new List<int>();
    void find_path(int row, int column, int[,] maps, int n)
    {
        maps[row, column] = n;
        rowCnt.Add(row);
        columnCnt.Add(column);
    }
}