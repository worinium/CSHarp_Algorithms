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
            Console.WriteLine("1 - Basic");
            Console.WriteLine("2 - Basic Algorithm");
            Console.WriteLine("3 - Array");
            Console.WriteLine("4 - Searching and Sorting");
            Console.WriteLine("5 - Function");
            Console.WriteLine("6 - Recursion");
            Console.WriteLine("7 - LINQ");
            Console.WriteLine("9 - Date Time");
            Console.WriteLine("10 - File Handling");

            int option = int.Parse(Console.ReadLine());
            if (option is 1)
            {//
                Basic();
            }
            if (option is 2)
            {//
                BasicAlgorithm();
            }
            if (option is 3)
            {//
                BasicArrayAction();
            }
            if (option is 2)
            {//
                SearchingAndSorting();
            }
            if (option is 2)
            {//
                Function();
            }
            if (option is 2)
            {//
                Recursion();
            }
            if (option is 2)
            {//
                LINQ();
            }
            if (option is 2)
            {//
                DateTimeActions();
            }
        }


        private static void Basic()
        {
            throw new NotImplementedException();
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
        private static void BasicArrayAction()
        {
            Console.WriteLine("Select one from the following Basic Arrays Excercise Solutions");
            Console.WriteLine("1. C# Sharp to store elements in an array and print it");
            Console.WriteLine("2. C# Sharp to read n number of values in an array and display it in reverse order");
            Console.WriteLine("3. C# Sharp to find the sum of all elements of the array");
            Console.WriteLine("4. C# Sharp to copy the elements one array into another array");
            Console.WriteLine("5. C# Sharp to count a total number of duplicate elements in an array");
            Console.WriteLine("6. C# Sharp to print all unique elements in an array");
            Console.WriteLine("7. C# Sharp to merge two arrays of same size sorted in ascending order");
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


        private static void SearchingAndSorting()
        {
            throw new NotImplementedException();
        }

        private static void Function()
        {
            throw new NotImplementedException();
        }
        private static void Recursion()
        {
            throw new NotImplementedException();
        }

        private static void LINQ()
        {
            throw new NotImplementedException();
        }
        private static void DateTimeActions()
        {
            throw new NotImplementedException();
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
