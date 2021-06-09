using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

public class Solution_12931
{
    public int solution(int n)
    {
        int answer = 0;
        int sum = 0;
        string str = n.ToString();

        for(int i = 0; i<str.Length; i++)
        {
            string newString = str[i].ToString();
            int.TryParse(newString, out sum);
            answer += sum;
        }

        return answer;
    }
}