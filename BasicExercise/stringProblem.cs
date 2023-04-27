using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercise
{
    public class stringProblem
    {
        public void Numbers()
        {
            Console.WriteLine("Enter A One String");
            string Name = Console.ReadLine();
            if(Name.Length > 4)
            {
                Console.WriteLine(Name.Length < 4 ? Name + Name + Name : Name.Substring(Name.Length - 4 ) + Name.Substring(Name.Length - 4) + Name.Substring(Name.Length - 4) + Name.Substring(Name.Length - 4));
            }
        }
    }
}
