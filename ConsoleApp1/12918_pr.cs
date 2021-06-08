using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution_12918
{
    public bool solution(string s)
    {
        bool answer = false;
        int result = 0;

        if(s.Length == 4 || s.Length == 6)
        {
            if(int.TryParse(s, out result))
            {
                answer = true;
            }
        }

        return answer;
    }
}