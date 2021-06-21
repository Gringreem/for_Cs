using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Solution_12981
{
    public int[] solution(int n, string[] words)
    {
        int[] answer = {0,0};
        bool check = false;
        int who = 0;
        int when = 1;

        List<string> list = new List<string>();
        list.Add(words[0]);
        who++;

        for(int i = 1; i < words.Length; ++i)
        {
            ++who;

            if(who > n)
            {
                when++;
                who -= n;
            }

            char last = words[i - 1].Last();
            char first = words[i].First();

            if(list.Contains(words[i]) || char.Equals(last, first) == false)
            {
                check = true;
                break;
            }

            list.Add(words[i]);
        }

        if (check == false)
        {
            who = 0;
            when = 0;
        }

        answer[0] = who;
        answer[1] = when;

        return answer;
    }
}