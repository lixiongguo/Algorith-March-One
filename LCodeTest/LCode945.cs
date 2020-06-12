using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCode
{
    class LCode945
    {
        public int MinIncrementForUnique(int[] A)
        {
            int Count = 0;
            int[] Map = new int[40000];
            for (int i = 0; i < A.Length; i++)
            {
                Map[A[i]]++; 
            }
            for (int i = 0; i < 40000; i++)
            {
                if (Map[i] > 1)
                {
                    Count += Map[i] - 1;
                    Map[i + 1] += Map[i] - 1;
                }
            }
            return Count;
        }
    }
}
