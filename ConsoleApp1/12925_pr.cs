using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution_12925
{
    public int solution(string s)
    {
        int answer = 0;

        int.TryParse(s, out answer);

        return answer;
    }
}