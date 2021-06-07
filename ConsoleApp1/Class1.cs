using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
    public string solution(string s)
    {
        string[] answer = new string[s.Length];

        for(int i = 0; i<s.Length; i++)
        {
            answer[i] = s[i];
        }


        return answer.ToString();
    }
}