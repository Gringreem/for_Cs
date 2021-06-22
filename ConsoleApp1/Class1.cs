using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
    public int solution(string skill, string[] skill_trees)
    {
        int answer = 0;
        int treeLen = skill_trees.Length;

        for(int i=0; i < treeLen; i++)
        {
            int skillLen = skill_trees[i].Length;
            for(int j =0; j < skillLen; j++)
            {
                char check = skill_trees[i][j];

                if(skill.IndexOf(check))

            }
        }
        return answer;
    }
}