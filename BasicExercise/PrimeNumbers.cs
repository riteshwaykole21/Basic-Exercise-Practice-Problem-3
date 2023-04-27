using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BasicExercise
{
    public class PrimeNumbers
    {
        public void Numbers()
        {
            Console.WriteLine("Enter a Number");
            int Number = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 2; i < Number; i++)
            {
                if(Number % i == 0)
                {
                    count++;
                }
            }
            if(count >= 1)
                Console.WriteLine("Its Not Prime Number");
            else
                Console.WriteLine("Its Prime Number");
        }
    }
}
