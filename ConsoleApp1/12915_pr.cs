using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution_12915
{
    public string[] solution(string[] strings, int n)
    {
        string[] answer = new string[strings.Length];

        for(int i = 0; i<strings.Length; i++)
        {
            answer[i] = (strings[i][n]) + strings[i];
        }
        Array.Sort(answer);
        
        for(int i = 0; i < strings.Length; i++)
        {
            answer[i] = answer[i].Substring(1);
        }


        return answer;
    }
}