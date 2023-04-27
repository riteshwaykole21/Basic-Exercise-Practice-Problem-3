using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercise
{
    public class MultiplyBy3Or7
    {
        public void Number()
        {
            Console.WriteLine("Enter A Number");
            int Number = Convert.ToInt32(Console.ReadLine());
            if (Number > 0)
            {
                if (Number % 3 == 0 || Number % 7 == 0)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }

        }
    }
}
