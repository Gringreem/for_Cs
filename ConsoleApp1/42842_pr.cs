using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Solution_42842
{
    public int[] solution(int brown, int yellow)
    {
        int[] answer = new int[2];
        int all = brown + yellow;
        int width = 0;
        int height = 0;

        for(int i = 1; i <= yellow; i++)
        {
            if(yellow%i == 0)
            {
                int j = yellow / i;
                int check = (2 * i) + (2 * j) + 4;
                if(check == brown)
                {
                    width = j + 2;
                    height = i + 2;
                    break;
                }
                else
                {
                    continue;
                }
            }
        }

        answer[0] = width;
        answer[1] = height;
        return answer;
    }
}