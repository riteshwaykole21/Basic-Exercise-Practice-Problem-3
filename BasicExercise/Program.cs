﻿using System;
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
            Console.WriteLine("3 : All Odd Number From 1 to 99");
            Console.WriteLine("4 : Sum Of First 500 Prime Number");
            Console.WriteLine("5 : String Reverse Fully");
            Console.WriteLine("6 : Multiply Two Array");
            Console.WriteLine("7 : String Problem");
            Console.WriteLine("8 : Multiply By 3 & 7");
            Console.WriteLine("9 : Check String Start With Specific Word ");
            Console.WriteLine("10 : Greater Than Less Than Program");
            Console.WriteLine("11 : Check An Integer");
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
                case 3:
                    LongWord longWord = new LongWord();
                    longWord.DataTest();
                    break;
                case 4:
                    PrimeNumbers primeNumbers = new PrimeNumbers();
                    primeNumbers.Numbers();
                    break;
                case 5:
                    stringReverse stringReverse = new stringReverse();
                    stringReverse.Number();
                    break;
                case 6:
                    MultiplyTwoArray multiplyTwoArray = new MultiplyTwoArray();
                    multiplyTwoArray.Numbers(); 
                    break;
                case 7:
                    stringProblem stringProblem = new stringProblem();
                    stringProblem.Numbers();
                    break;
                case 8:
                    MultiplyBy3Or7 multiplyBy3Or7 = new MultiplyBy3Or7();
                    multiplyBy3Or7.Number();
                    break;
                case 9:
                    CheckString check = new CheckString();
                    check.Numbers();
                    break;
                case 10:
                    GreaterAndLess greaterAndLess = new GreaterAndLess();
                    greaterAndLess.Number();
                    break;
                case 11:
                    CheckIntegers checkIntegers = new CheckIntegers();
                    checkIntegers.Numbers();    
                    break;
            }
            Console.ReadLine();
        }
    }
}
