using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution_12926
{
    public string solution(string s, int n)
    {
        string answer = "";

        for(int i = 0; i<s.Length; i++)
        {
            if (65 <= s[i] && s[i] <= 90)
            {
                if(s[i]+n > 90)
                {
                    answer += (char)(s[i] + n - 26);
                }
                else
                {
                    answer += (char)(s[i] + n);
                }
            }
            else if(97<= s[i] && s[i] <= 122)
            {
                if(s[i] + n > 122)
                {
                    answer += (char)(s[i] + n - 26);
                }
                else
                {
                    answer += (char)(s[i] + n);
                }
            }
            else
            {
                answer += " ";
            }
        }

        return answer;
    }
}