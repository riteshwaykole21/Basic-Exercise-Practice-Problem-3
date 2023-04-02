using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 : Check The Sum Of Two Given Interger");
            Console.WriteLine("2 : Convert String Into Lower Case");
            Console.WriteLine("Enter The Option");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch (Option)
            {
                case 1:
                    CheckSum checkSum = new CheckSum();
                    checkSum.Solution();
                    break;
                case 2:
                    GivenString givenString = new GivenString();
                    givenString.Sample();
                    break;
            }
            Console.ReadLine();
        }
    }
}
