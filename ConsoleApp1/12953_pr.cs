using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution_12953
{
    public int solution(int[] arr)
    {
        int answer = 0;
        int LCM = arr[0] * arr[1] / gcd(arr[0],arr[1]);

        for(int i = 2; i < arr.Length; i++)
        {
            LCM = LCM * arr[i] / gcd(LCM, arr[i]);
        }

        answer = LCM;
        return answer;
    }

    int gcd(int a, int b)
    {
        return (a % b == 0 ? b : gcd(b, a % b));
    }
}