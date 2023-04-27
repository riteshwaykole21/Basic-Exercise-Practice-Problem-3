using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercise
{
    public class CheckString
    {
        public void Numbers()
        {
            Console.WriteLine("Enter A String");
            string Name = Console.ReadLine();
            Console.WriteLine(Name.Equals("Hello") || Name.StartsWith("Hello"));
        }
    }
}
