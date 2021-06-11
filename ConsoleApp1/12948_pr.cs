using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution_12948
{
    public string solution(string phone_number)
    {
        string answer = "";
        int len = phone_number.Length;

        for(int i = 0; i < len - 4; i++)
        {
            answer += "*";
        }
        for(int i = len-4; i<len; i++)
        {
            answer += phone_number[i];
        }

        return answer;
    }
}