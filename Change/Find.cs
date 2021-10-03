using System;
using System.Collections.Generic;
using System.Text;

namespace Change
{
    class Find
    {
        public int FindSum(int n,int m)
        {
            int sum = 0;
            for(int i = n; i < m; i++)
            {
                sum += i;
            }
            return sum;
        }
        public int FindCount(int n,int m)
        {
            int count = 0;
            for(int i = n; i < m; i++)
            {
                count++;
            }
            return count;
        }
    }
}
