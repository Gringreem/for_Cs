using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution_49993
{
    public int solution(string skill, string[] skill_trees)
    {
        int answer = 0;
        
        foreach(var str in skill_trees)
        {
            bool right = true;
            List<char> str_list = str.ToCharArray().ToList();

            for(int i = 0; i < skill.Length - 1; ++i)
            {
                int prev = str_list.FindIndex(x => x == skill[i]);
                int next = str_list.FindIndex(x => x == skill[i+1]);

                if((prev>next && next>=0) || (prev<0 && next >= 0))
                {
                    right = false;
                    break;
                }
            }
            
            if (right)
            {
                answer++;
            }
        }

        return answer;
    }
}