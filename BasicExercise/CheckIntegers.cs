using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercise
{
    public class CheckIntegers
    {
        public void Numbers()
        {
            string Name = "Hello";
            char[] Name1 = Name.ToCharArray();
            for (int i = 0; i < Name1.Length; i++)
            {
                if (Char.IsUpper(Name1[i]))
                {
                    Name1[i] = Char.ToLower(Name1[i]);   
                }
                else if (Char.IsLower(Name1[i]))
                {
                    Name1[i] = Char.ToUpper(Name1[i]);
                }
            }
            string Result = new string(Name1);
            Console.WriteLine(Result);
        }
    }
}
