using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution_12947
{
    public bool solution(int x)
    {
        bool answer = false;
        string str = x.ToString();
        int sum = 0;

        for(int i = 0; i < str.Length; i++)
        {
            sum += Int32.Parse(str.Substring(i, 1));
        }
        if(x%sum == 0)
        {
            answer = true;
        }

        return answer;
    }
}