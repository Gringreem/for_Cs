using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution_12940
{
    public int[] solution(int n, int m)
    {
        int _gcd = gcd(n, m);
        int[] answer = new int[] { _gcd, n * m / _gcd };

        return answer;
    }

    int gcd(int a, int b)
    {
        return (a % b == 0 ? b : gcd(b, a % b));
    }
}