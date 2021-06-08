using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution_12921
{
    public int solution(int n)
    {
        bool[] arr = Enumerable.Repeat<bool>(false, n).ToArray();
        arr[0] = true;

        for(int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (arr[i - 1] == true) continue;
            for(int j = i*2; j<=n; j += i)
            {
                if (arr[j - 1] == true) continue;
                arr[j - 1] = true;
            }
        }


        return arr.Where(x=>x==false).Count();
    }
}