using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Solution_12941
{
    public int solution(int[] A, int[] B)
    {
        int answer = 0;
        Array.Sort(A);
        Array.Sort(B);

        for(int i = 0; i < A.Length; i++)
        {
            answer += A[i] * B[B.Length - 1 - i];
        }

        return answer;
    }
}