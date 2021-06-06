using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution_42748
{
    public int[] solution(int[] array, int[,] commands)
    {
        List<int> answer = new List<int>();

        for(int i = 0; i < commands.GetLength(0); i++)
        {
            List<int> newList = new List<int>();

            for (int j = commands[i, 0]-1; j < commands[i, 1]; j++)
            {
                newList.Add(array[j]);
            }
            newList.Sort();
            answer.Add(newList[commands[i, 2] - 1]);
        }


        return answer.ToArray();
    }
}
