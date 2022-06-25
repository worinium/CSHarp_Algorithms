using CSHarp_Algorithms.Arrays;
using System;

namespace CSHarp_Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExecuteAction();

        }

        private static void ExecuteAction()
        {
            Console.WriteLine("Select The Algorithm to Perform");
            Console.WriteLine("1 - Basic Algorithm");
            Console.WriteLine("2 - Basic Arrays");
            Console.WriteLine("3 - Basic Arrays");
            Console.WriteLine("4 - Basic Arrays");
            Console.WriteLine("5 - Basic Arrays");
            Console.WriteLine("6 - Basic Arrays");
            Console.WriteLine("7 - Basic Arrays");
            Console.WriteLine("9 - Basic Arrays");
            Console.WriteLine("10 - Basic Arrays");
            int option = int.Parse(Console.ReadLine());
            if (option is 1)
            {//

            }
            if (option is 2)
            {//
                BasicArrayAction();
            }
        }

        private static void BasicArrayAction()
        {
            Console.WriteLine("Select one from the following Basic Arrays Excercise Solutions");
            Console.WriteLine("1. Basic Algorithm");
            Console.WriteLine("2. Basic Arrays");
            Console.WriteLine("3. Basic Arrays");
            Console.WriteLine("4. Basic Arrays");
            Console.WriteLine("5. Basic Arrays");
            Console.WriteLine("6. Basic Arrays");
            Console.WriteLine("7. Basic Arrays");
            Console.WriteLine("9, Basic Arrays");
            Console.WriteLine("1. Basic Arrays");
            int caseOption = int.Parse(Console.ReadLine());
            if (caseOption == 1)
                ArrayService.GetExercise1();
            if (caseOption == 2)
                ArrayService.GetExercise2();
            if (caseOption == 3)
                ArrayService.GetExercise3();
            if (caseOption == 4)
                ArrayService.GetExercise4();
            if (caseOption == 5)
                ArrayService.GetExercise5();
            if (caseOption == 6)
                ArrayService.GetExercise6();
            if (caseOption == 7)
                ArrayService.GetExercise7();
            if (caseOption == 8)
                ArrayService.GetExercise8();
            if (caseOption == 9)
                ArrayService.GetExercise9();
            if (caseOption == 10)
                ArrayService.GetExercise10();
            ContinueAgain("BasicArrayAction");
        }
        private static void BasicAlgorithm()
        {
            Console.WriteLine("Select one from the following Basic Algorithm Excercise Solutions");
            Console.WriteLine("1. Basic Algorithm");
            Console.WriteLine("2. Basic Arrays");
            Console.WriteLine("3. Basic Arrays");
            Console.WriteLine("4. Basic Arrays");
            Console.WriteLine("5. Basic Arrays");
            Console.WriteLine("6. Basic Arrays");
            Console.WriteLine("7. Basic Arrays");
            Console.WriteLine("9, Basic Arrays");
            Console.WriteLine("1. Basic Arrays");

            int caseOption = int.Parse(Console.ReadLine());
            if (caseOption == 1)
                ArrayService.GetExercise1();
            if (caseOption == 2)
                ArrayService.GetExercise2();
            if (caseOption == 3)
                ArrayService.GetExercise3();
            if (caseOption == 4)
                ArrayService.GetExercise4();
            if (caseOption == 5)
                ArrayService.GetExercise5();
            if (caseOption == 6)
                ArrayService.GetExercise6();
            if (caseOption == 7)
                ArrayService.GetExercise7();
            if (caseOption == 8)
                ArrayService.GetExercise8();
            if (caseOption == 9)
                ArrayService.GetExercise9();
            if (caseOption == 10)
                ArrayService.GetExercise10();
            ContinueAgain("BasicAlgorithm");
        }

        static void ContinueAgain(string action = "")
        {
            Console.WriteLine("Do You want to perform another operation (Y/N)");
            string option = Console.ReadLine();
            if (string.IsNullOrEmpty(option) || option.ToLower() is "no" || option.ToLower() is "n")
            {
                Console.WriteLine("Wrong Input");
                ContinueAgain();
            }
            if (option.ToLower() is "no" || option.ToLower() is "n")
            {
                Environment.Exit(0);
            }
            if (option.ToLower() is "yes" || option.ToLower() is "y")
            {
                if (action == "BasicAlgorithm")
                {
                    //BasicAlgorithm();
                    Console.WriteLine("Choose Appropriate Option");
                    Console.WriteLine("1. Go Back To Main Menu");
                    Console.WriteLine("2. Basic Algorithm");
                    int opt = int.Parse(Console.ReadLine());
                    if (opt is 1)
                    {
                        ExecuteAction();
                    }
                    if (opt is 2)
                    {
                        BasicAlgorithm();
                    }

                }
                if (action == "BasicArrayAction")
                {
                    //BasicArrayAction();
                    Console.WriteLine("Choose Appropriate Option");
                    Console.WriteLine("1. Go Back To Main Menu");
                    Console.WriteLine("2. Basic Array Algorithm");
                    int opt = int.Parse(Console.ReadLine());
                    if (opt is 1)
                    {
                        ExecuteAction();
                    }
                    if (opt is 2)
                    {
                        BasicArrayAction();
                    }
                }
            }
        }
    }
}
