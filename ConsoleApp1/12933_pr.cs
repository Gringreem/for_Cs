using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution_12933
{
    public long solution(long n)
    {
        long answer = 0;
        string str = n.ToString();
        char[] arr = str.ToCharArray();

        for(int i = 0; i < arr.Length; i++)
        {
            for(int j=i+1; j<arr.Length; j++)
            {
                if (arr[i] < arr[j])
                {
                    char temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                }
            }
        }
        answer = Int64.Parse(arr);

        return answer;
    }
}