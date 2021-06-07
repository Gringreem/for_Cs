using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution_68935
{
    public int solution(int n)
    {
        int answer = 0;
        string result = "";

        while (true)
        {
            int a = n / 3;
            int b = n % 3;

            n = a;
            result += b.ToString();

            if (n == 0)
            {
                break;
            }
            if (n < 3)
            {
                result += a.ToString();
                break;
            }
        }

        int len = result.Length - 1;

        for(int i = 0; i < result.Length; i++)
        {
            int pow = (int)Math.Pow(3, len--);
            answer += int.Parse(result[i].ToString()) * pow;
        }

        return answer;
    }
}
