using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
    public int answer = 0;
    public int solution(int[] numbers, int target)
    {
        int len = numbers.Length;

        check(0,0,len,target,numbers);

        return answer;
    }
    public void check(int count, int sum, int len,int target,int[] numbers)
    {
        if (count == len)
        {
            if (sum == target)
            {
                answer++;
            }
        }
        check(count + 1, sum + numbers[count],len,target,numbers);
        check(count + 1, sum - numbers[count],len,target,numbers);
    }
}