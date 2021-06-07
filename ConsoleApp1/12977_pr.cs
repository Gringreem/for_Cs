using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Solution_12977
{
    public int solution(int[] nums)
    {
        int answer = 0;
        int sum = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                for(int k = j + 1; k < nums.Length; k++)
                {
                    int count = 0;
                    sum = nums[i] + nums[j] + nums[k];
                    for(int a = 2; a < sum; a++)
                    {
                        if (sum % a == 0) count++;

                    }
                    if (count == 0) answer++;
                }
            }
        }
        
        return answer;
    }
}