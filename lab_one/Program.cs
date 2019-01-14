using System;
using System.Collections.Generic;

namespace lab_one
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] answerKey = { 'B', 'B', 'C', 'A', 'D',
                                'A', 'A', 'C', 'D', 'A' };
            char[] options = { 'A', 'B', 'C', 'D' };
            char[] userAnswer = new char[10];
            
            for(int i = 0; i < 10; i++)
            {
                switch (i)
                {
                    case 0:
                        scramble(options);
                        Console.WriteLine("Question 1: ");
                        break;
                    default:
                        Console.WriteLine("Defult case");
                        break;
                }
            }

            char[] scramble(char[] opArray)
            {
                Random rand = new Random();
                return opArray;
            }
        }
    }
}
