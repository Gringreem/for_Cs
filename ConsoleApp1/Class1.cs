using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
    public string solution(string s)
    {
        string answer = "";
        string answe = "";

        string[] ss = s.Split(" ");

        for(int i=0; i < ss.Length; i++)
        {
            for(int j = 0; j<ss[i].Length; j++)
            {
                if (j % 2 == 0)
                {
                    answe += Char.ToUpper(ss[i][j]);
                }
                else
                {
                    answe += ss[i][j];
                }
            }
            answe += " ";
        }
        for(int i =0; i<s.Length; i++)
        {
            answer += answe[i];
        }

        return answer;
    }
}