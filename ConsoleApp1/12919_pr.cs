using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution_12919
{
    public string solution(string[] seoul)
    {
        string answer = "";
        int count = 0;

        for(int i = 0; i < seoul.Length; i++)
        {
            if(seoul[i] == "Kim")
            {
                count = i;
                break;
            }
        }

        answer = "김서방은 " + count + "에 있다";

        return answer;
    }
}