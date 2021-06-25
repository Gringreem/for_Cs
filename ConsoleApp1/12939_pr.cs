using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Solution_12939
{
    public string solution(string s)
    {
        string answer = "";
        string[] str_arr = s.Split(" ");
        int[] int_arr = new int[str_arr.Length];
        
        for(int i = 0; i < str_arr.Length; i++)
        {
            int.TryParse(str_arr[i], out int_arr[i]);
        }
        Array.Sort(int_arr);

        answer += int_arr[0];
        answer += " ";
        answer += int_arr[int_arr.Length-1];

        return answer;
    }
}