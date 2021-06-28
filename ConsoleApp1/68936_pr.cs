using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Solution_68936
{
    public int[] ans = { 0, 0 };
    public int[] solution(int[,] arr)
    {
        int[] answer = new int[2];
        divide(arr, 0, 0, arr.GetLength(0));

        answer[0] = ans[0];
        answer[1] = ans[1];
        return answer;
    }

    void divide(int[,] arr, int a, int b, int c)
    {
        int val = arr[a, b];
        if (c == 1)
        {
            ans[val]++;
            return;
        }
        bool check = true;
        for(int i = a; i < a + c; i++)
        {
            for(int j = b; j < b + c; j++)
            {
                if (arr[i, j] != val)
                {
                    check = false;
                }
            }
        }
        if (check)
        {
            ans[val]++;
        }
        else
        {
            c /= 2;
            divide(arr, a, b, c);
            divide(arr, a, b + c, c);
            divide(arr, a + c, b, c);
            divide(arr, a + c, b + c, c);
        }

    }
}