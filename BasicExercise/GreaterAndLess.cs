using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercise
{
    public class GreaterAndLess
    {
        public void Number()
        {
            Console.WriteLine("Enter A First Number");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter A Second Number");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((M < 100 && N > 200));
        }
    }
}
