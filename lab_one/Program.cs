using System;
using System.Collections.Generic;

namespace lab_one
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] AnswerKey = { "B", "B", "C", "A", "D", "A", "A", "C", "D", "A" };
            string[] quizQuestions = { "when was .NET core released?", "What is the current version of .NET core?", "which operating system does NOT support .NET Core?",
                                        ".NET project was created by...", "What languages can be used to write applications and libraries for .NET Core?",
                                        "How do you create a C# application from a command prompt?", "Which of the following is a .NET API?",
                                        "Which framework was NOT built on top of .NET Core?",".NET Core is composed of which following parts?" ,
                                        ".NET is licensed by..."
                                         };
            string[,] quizOptions = {{ "2019", "2016", "2003", "1990" },
                                     {"1.0","2.2","10.0","3.0" },
                                     {"Windows", "MacOS", "iOS", "Linux"},
                                     {"Open Source", "Microsoft","Intel","Apple" },
                                     {"C#","Visual Basic","F#","All of the above"},
                                     {"dotnet new console",".NET new console","dotnet run","new console"},
                                     {"System.Collections.Generic.List<T>","java.applet", "sys", "boolean"},
                                     {"ASP.NET Core","UWP","Apache Spark","Tizen"},
                                     {".NET Core runtime", "ASP .NET runtime",".NET Core CLI tools","All of the above" },
                                     {"MIT license", "Apache License", "GNU Lesser Public License", "None of the above" }

                                    };
            string[] options = { "A) ", "B) ", "C) ", "D) " };
            string[] userSelection = new string[10];

            ConsoleKey keyPressed = new ConsoleKey();

            Console.WriteLine("Press ENTER to continue...");

            while(keyPressed != ConsoleKey.Enter)
            {
                keyPressed = Console.ReadKey().Key;
            }

            for (int i = 0; i < quizQuestions.Length; i++)
            {
                Console.Clear();
                Console.WriteLine(quizQuestions[i]);
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(options[j]);
                    Console.WriteLine(quizOptions[i, j]);
                }
                Console.WriteLine("Please enter an option");
                userSelection[i] = Console.ReadLine();
                if(userSelection[i] == AnswerKey[i])
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Correct!");
                    System.Threading.Thread.Sleep(500);
                }
                else
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Sorry, incorrect.");
                    System.Threading.Thread.Sleep(500);
                }
                Console.BackgroundColor = ConsoleColor.Black;
            }
            /*
            string[] scramble(char[] opArray, string[] questionOp)
            {
                Random rand = new Random();
                string[] newOptions = new string[4];
                for (int i = 0; i < 4; i++)
                {
                    
                }

                return newOptions;
            }*/
        }
    }
}
