using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercise
{
    public class stringReverse
    {
        public void Number()
        {
            Console.WriteLine("Enter A One String");
            string Name = Console.ReadLine();
            string[] Word = Name.Split(' ');    
            Array.Reverse(Word);
            foreach (string iteam in Word)
            {
                Console.Write(iteam + " ");
            }
        }
    }
}
