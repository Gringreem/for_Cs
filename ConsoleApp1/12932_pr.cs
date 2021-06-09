using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution_12932
{
    public int[] solution(long n)
    {
        int sum = 0;
        string str = n.ToString();
        int[] answer = new int[str.Length];

        for (int i = str.Length-1; i >= 0; i--)
        {
            string newString = str[i].ToString();
            int.TryParse(newString, out sum);
            answer[str.Length - i - 1] = sum;
        }

        return answer;
    }
}