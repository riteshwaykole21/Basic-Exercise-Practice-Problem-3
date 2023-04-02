using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercise
{
    public class CheckSum
    {
        public void Solution()
        {
            Console.WriteLine("Enter The First Number");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Second Number ");
            int Y = Convert.ToInt32(Console.ReadLine());
            if (X == 20)
            {
                Console.WriteLine("True");
            }
            else if (Y == 20)
            {
                Console.WriteLine("True");
            }
            else if (X+Y == 20)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
