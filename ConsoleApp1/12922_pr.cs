using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution_12922
{
    public string solution(int n)
    {
        string answer = "";

        if(n%2 == 0)
        {
            for(int i = 0; i < n; i += 2)
            {
                answer += "수박";
            }
        }
        else
        {
            answer += "수";
            for(int i = 1; i < n; i += 2)
            {
                answer += "박수";
            }
        }

        return answer;
    }
}