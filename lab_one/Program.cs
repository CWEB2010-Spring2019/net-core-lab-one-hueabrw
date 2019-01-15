using System;
using System.Collections.Generic;

namespace lab_one
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declerations
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

            bool quit = false;

            //Main code starts here
            while (!quit)
            {
                if (keyPressed != ConsoleKey.Enter)
                {
                    Console.WriteLine("Press ENTER to start...");
                    keyPressed = Console.ReadKey().Key;
                }
                else
                {
                    for (int i = 0; i < quizQuestions.Length; i++)
                    {
                        //Presents Questions
                        Console.Clear();
                        Console.WriteLine(quizQuestions[i]);
                        //Presents Multiple Choice Options
                        for (int j = 0; j < quizOptions.GetLength(1); j++)
                        {
                            Console.Write(options[j]);
                            Console.WriteLine(quizOptions[i, j]);
                        }
                        //Asks for user input
                        Console.WriteLine("Please enter an option");
                        userSelection[i] = Console.ReadLine().ToUpper();

                        //Flashes the screen green and says correct if they're right
                        if (userSelection[i] == AnswerKey[i])
                        {
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Correct!");
                            System.Threading.Thread.Sleep(500);
                        }
                        //Flashes the screen red and says incorrect if they're wrong
                        else
                        {
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Sorry, incorrect.");
                            System.Threading.Thread.Sleep(500);
                        }
                        //resets the background to black
                        Console.BackgroundColor = ConsoleColor.Black;
                    }

                    //counting number they got right
                    int numberCorrect = 0;

                    //Presents their answers and the asnwer key side by side
                    Console.Clear();
                    Console.WriteLine("\n\t|Question|Your Answer|Correct Answer|");
                    for(int i = 0; i < quizQuestions.Length; i++)
                    {
                        Console.Write("\t");
                        //Set background to green if they're right
                        if (userSelection[i] == AnswerKey[i])
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            numberCorrect++;
                        }
                        //Set background to red if they're wrong
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                        }
                        //formatting code
                        string num = "";
                        if(i < 9)
                        {
                            num = "0";
                        }

                        Console.WriteLine("|"+ num + (i+1) + "      |" + userSelection[i] + "          |" + AnswerKey[i] + "             |");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }

                    //resets the background to black

                    float userPercentege = (float)numberCorrect / (float)quizQuestions.Length;
                    Console.WriteLine("\nYou got " + (userPercentege * 100.00f) + "% correct.");
                    if(userPercentege < 0.7f)
                    {
                        Console.WriteLine("You failed.");
                    }
                    else
                    {
                        Console.WriteLine("Congratulations, you passed!");
                    }

                    bool answered = false;

                    while (!answered)
                    {
                        Console.WriteLine("Do you want to try again?(Y/N)");
                        keyPressed = Console.ReadKey().Key;
                        Console.WriteLine();
                        if (keyPressed == ConsoleKey.Y)
                        {
                            answered = true;
                            Console.Clear();
                        }else if(keyPressed == ConsoleKey.N)
                        {
                            answered = true;
                            quit = true;
                        }
                        else
                        {
                            Console.WriteLine("Not a valid answer...");
                        }
                    }

                }

            }
        }
    }
}
