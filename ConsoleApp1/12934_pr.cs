using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution_12934
{
    public long solution(long n)
    {
        double sqrt = Math.Sqrt(n);

        return sqrt % 1 == 0 ? (long)((sqrt + 1) * (sqrt + 1)) : -1;
    }
}