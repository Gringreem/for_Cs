using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution_42862
{
    public int solution(int n, int[] lost, int[] reserve)
    {

        List<int> lostList = lost.ToList();
        List<int> reserveList = reserve.ToList();

        for(int i = 0; i < reserve.Length; i++)
        {
            if (lostList.Contains(reserve[i]))
            {
                lostList.Remove(reserve[i]);
                reserveList.Remove(reserve[i]);
            }
        }

        int[] reserve_2 = reserveList.ToArray();

        for(int i = 0; i < reserve_2.Length; i++)
        {
            int front = reserve_2[i] - 1;
            int rear = reserve_2[i] + 1;
            
            if (lostList.Contains(front))
            {
                lostList.Remove(front);
                continue;
            }
            if (lostList.Contains(rear))
            {
                lostList.Remove(rear);
                continue;
            }
            
        }

        return n - lostList.ToArray().Length;
    }
}