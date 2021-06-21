using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Solution_42839
{
    public int solution(string numbers)
    {
        int answer = 0;
        char[] arr = numbers.ToArray();
        int[] number = new int[arr.Length]; 
        for(int i = 0; i<arr.Length; i++)
        {
            number[i] = int.Parse(arr[i].ToString());
        }



        return answer;
    }

    private int check(int[] array)
    {
        int check = 0;
        for(int i = 0; i < array.Length; i++)
        {
            int count = 0;
            for(int j = 2; j<array[i]; j++)
            {
                if (array[i] % j == 0) count++;

            }
            if (count == 0) check++;
        }

        return check;
    }
}