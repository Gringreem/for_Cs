using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution_77885
{
    public long[] solution(long[] numbers)
    {
        List<long> answer = new List<long>();

        for(int i=0; i<numbers.Length; ++i)
        {
            if(numbers[i] % 2 == 0)
            {
                answer.Add(numbers[i] + 1);
            }
            else
            {
                long bit = 1;
                while (true)
                {
                    if((numbers[i] & bit) == 0){
                        break;
                    }
                    bit *= 2;
                }
                bit /= 2;
                answer.Add(numbers[i] + bit);
            }
        }
        
        return answer.ToArray();
    }
}
