using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution_12917
{
    public string solution(string s)
    {
        string answer = "";
        char[] sArray = s.ToArray();

        Array.Sort(sArray);

        for(int i = s.Length-1; i>=0; i--)
        {
            answer += sArray[i];
        }


        return answer;
    }
}