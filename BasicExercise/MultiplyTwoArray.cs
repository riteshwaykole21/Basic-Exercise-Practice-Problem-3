using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercise
{
    public class MultiplyTwoArray
    {
        public void Numbers()
        {
            int[] Array1 = { 1, 2, 3, 4, };
            int[] Array2 = { 6, 7, 8, 9, };
            int Result = 0;
            for (int i = 0; i < Array1.Length; i++)
            {
                 Result = Array1[i] * Array2[i];
                 Console.Write(Result + " ");
            }
        }
    }
}
