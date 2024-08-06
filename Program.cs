using System;
using System.Diagnostics.Metrics;
using System.Numerics;


namespace NumberAnalizer
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runProgram = true;
            while (runProgram == true)

            {


                Console.WriteLine("Welcome to the Number Analizer");
                Console.Write("What is your name please?: ");
                string userName = Console.ReadLine();

               
                int number = 0;

                do
                {
                    Console.Write("Hello " + userName + " Please enter a number between 1 and 100: ");
                    number = int.Parse(Console.ReadLine());
                } while (number < 0 || number > 100);



                Console.WriteLine("You have entered a correct number. ");


                if (number < 60 && number % 2 == 1)
                {

                    Console.WriteLine(userName + " The number you entered " + number + " Is odd and less than 60.");
                }
                else if (number >= 2 && number <= 24 && number % 2 == 0)
                {

                    Console.WriteLine(userName + " The number you entered " + number + " Is even and less than 25");
                }
                else if (number >= 26 && number <= 60 && number % 2 == 0)
                {

                    Console.WriteLine(userName + " The number you entered " + number + " Is even and between 26 and 60 inclusive");
                }
                else if (number > 60 && number <= 100 && number % 2 == 0)

                {

                    Console.WriteLine(userName + " The number you entered " + number + " Is even and greater than 60");
                }
                else if (number > 60 && number <= 100 && number % 2 == 1)
                {
                    Console.WriteLine(userName + " The nuber you entered " + number + " Is odd and greater than 60");
                }
                while (true)
                {
                    Console.WriteLine("Would you like to continue? y/n");
                    string loopChoice = Console.ReadLine();
                    if (loopChoice == "y")
                    {
                        break;

                    }
                    else if (loopChoice == "n")
                    {
                        runProgram = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("invalid");
                    }
                }
            }
        }   } }
            
            
         


    
