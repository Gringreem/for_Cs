using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution_76502
{
    public int solution(string s)
    {
        int answer = 0;
        bool check = true;
        char[] str = s.ToArray();

        for (int i = 0; i < s.Length; i++)
        {
            string new_str = "";
            for (int j = 0; j < s.Length; j++)
            {
                if (i + j < 6)
                {
                    new_str += str[i + j];
                }
                else
                {
                    new_str += str[i + j - 6];
                }
            }

            List<char> stack = new List<char>();

            for (int j = 0; j < new_str.Length; j++)
            {
                int top = -1;
                if (new_str[j] == '[' || new_str[j] == '{' || new_str[j] == '(')
                {
                    stack.Add(new_str[j]);
                    top++;
                }
                else if (top < 0)
                {
                    check = false;
                    break;
                }
                else
                {
                    stack.Remove(stack[top--]);
                }
            }
            if(check == true)
            {
                answer++;
            }
        }



        return answer;
    }
}