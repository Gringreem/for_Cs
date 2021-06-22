using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution_42860
{
    public int solution(string name)
    {
        int answer = 0;
        int end = name.Length - 1;

        for(int i = 0; i < name.Length; i++)
        {
            int next = i + 1;
            if(name[i] <= 'N')
            {
                answer += name[i] - 'A';
            }
            else
            {
                answer += 'Z' - name[i] + 1;
            }
            while(next<name.Length && name[next] == 'A')
            {
                next++;
            }
            end = Math.Min(end, i + name.Length - next + Math.Min(i, name.Length - next));
        }

        answer += end;
        return answer;
    }
}