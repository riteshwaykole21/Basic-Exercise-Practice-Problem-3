﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercise
{
    public class LongWord
    {
        public void DataTest()
        {
            for (int i = 0; i < 100; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine( i );
                }
            }
        }
    }
}
