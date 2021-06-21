using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution_42883
{
    public string solution(string number, int k)
    {
        string answer = "";
        int size = number.Length - k;
        List<int> numList = new List<int>(size);
        int count = 0;

        for(int i = 0; i < size; i++)
        {
            char maxC = number[count];
            int maxI = count;
            for(int j = count; j <= k + i; j++)
            {
                if (maxC < number[j])
                {
                    maxC = number[j];
                    maxI = j;
                }
            }
            count = maxI + 1;
            numList.Add((int)Char.GetNumericValue(maxC));
        }
        answer = string.Join("",numList);
        return answer;

    }
}