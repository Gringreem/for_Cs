using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution_12903
{
    public string solution(string s)
    {
        string answer = "";
        int half = s.Length / 2;

        if(s.Length %2 == 0)
        {
            answer += s[half - 1];
            answer += s[half];
        }
        else
        {
            answer += s[half];
        }

        return answer;
    }
}