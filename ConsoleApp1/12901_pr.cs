using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution_12901
{
    public string solution(int a, int b)
    {
        string answer = "";
        int[] day = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        int sum = 0;

        if(a == 1)
        {
            sum += b;
        }
        else
        {
            for(int i = 0; i < a-1; i++)
            {
                sum += day[i];
            }
            sum += b;
        }

        sum -= 1;

        switch ( sum%7 )
        {
            case 0:
                answer = "FRI";
                break;
            case 1:
                answer = "SAT";
                break;
            case 2:
                answer = "SUN";
                break;
            case 3:
                answer = "MON";
                break;
            case 4:
                answer = "TUE";
                break;
            case 5:
                answer = "WED";
                break;
            case 6:
                answer = "THU";
                break;
        }


        return answer;
    }
}