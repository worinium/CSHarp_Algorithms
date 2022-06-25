using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHarp_Algorithms.Arrays
{
    public class ArrayService
    {
        internal static void GetExercise1()
        {
            /*
            1.Write a program in C# Sharp to store elements in an array and print it. Go to the editor
            Test Data:
                Input 10 elements in the array:
                element - 0 : 1
                element - 1 : 1
                element - 2 : 2
            */
            int[] arr = new int[10];
            int i;
            Console.Write("\n\nRead and Print elements of an array:\n");
            Console.Write("-----------------------------------------\n");

            Console.Write("Input 10 elements in the array :\n");
            for (i = 0; i < 10; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nElements in array are: ");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.Write("\n");
        }
        internal static void GetExercise2()
        {
            /*
            2. Write a program in C# Sharp to read n number of values in an array and display it in reverse order. Go to the editor
                Test Data :
                Input the number of elements to store in the array :3
                Input 3 number of elements in the array :
                element - 0 : 2
                element - 1 : 5
                element - 2 : 7
            */
            Console.Write("Input the number of elements to be stored in the array : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[] arr = new int[n];
            int i;

            Console.Write($"Input {n} elements in the array :\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            arr.ToList().ForEach(x => Console.Write(x + " "));
            Console.WriteLine();
            Console.Write("\nElements in Revers form: ");
            for (i = n - 1; i >= 0; i--)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.Write("\n");
        }


        internal static void GetExercise3()
        {
            /*
            3. Write a program in C# Sharp to find the sum of all elements of the array. Go to the editor
                Test Data :
                Input the number of elements to be stored in the array :3
                Input 3 elements in the array :
                element - 0 : 2
                element - 1 : 5
                element - 2 : 8
                Expected Output :
                Sum of all elements stored in the array is : 15
            */
            Console.Write("Input the number of elements to be stored in the array : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[] arr = new int[n];
            int i;

            Console.Write($"Input {n} elements in the array :\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Sum of all elements stored in the array is : " + arr.Sum());

        }
        internal static void GetExercise4()
        {
            /*
            4. Write a program in C# Sharp to copy the elements one array into another array. Go to the editor
            Test Data :
            Input the number of elements to be stored in the array :3
            Input 3 elements in the array :
            element - 0 : 15
            element - 1 : 10
            element - 2 : 12
            Expected Output:
            The elements stored in the first array are :
            15 10 12
            The elements copied into the second array are :
            15 10 12
            */
            Console.Write("Input the number of elements to be stored in the array : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[] arr = new int[n], arr2 = new int[n];
            int i;

            Console.Write($"Input {n} elements in the array :\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            //  Array.Copy(arr, 0, arr2, 0, n);
            arr.CopyTo(arr2, 0);

            Console.WriteLine();
            Console.Write("Original Array Elements: ");
            arr.ToList().ForEach(x => Console.Write(x + " "));
            Console.WriteLine();
            Console.Write("Copied Array Elements : ");
            arr2.ToList().ForEach(x => Console.Write(x + " "));

        }
        internal static void GetExercise5()
        {
            /*
            5. Write a program in C# Sharp to count a total number of duplicate elements in an array. Go to the editor
            Test Data :
            Input the number of elements to be stored in the array :3
            Input 3 elements in the array :
            element - 0 : 5
            element - 1 : 1
            element - 2 : 1
            Expected Output :
            Total number of duplicate elements found in the array is : 1
            */
            Console.Write("Input the number of elements to be stored in the array : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[] arr = new int[n], arr2 = new int[n], arr3 = new int[n];
            int i, j, mm = 1, ctr = 0;

            Console.Write($"Input {n} elements in the array :\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            arr.CopyTo(arr2, 0);
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (arr[i] == arr2[j])
                    {
                        arr3[j] = mm;
                        mm++;
                    }
                }
                mm = 1;
            }
            /*--------------- Prints the array ------------------------------------*/
            for (i = 0; i < n; i++)
            {
                if (arr3[i] == 2)
                {
                    ctr++;
                }
            }
            Console.Write("The number of duplicate elements is: {0} \n", ctr);
            Console.Write("\n\n");
        }
        internal static void GetExercise6()
        {
            /*
            6. Write a program in C# Sharp to print all unique elements in an array. Go to the editor
            Test Data :
            Input the number of elements to be stored in the array :3
            Input 3 elements in the array :
            element - 0 : 1
            element - 1 : 5
            element - 2 : 1
            Expected Output :
            The unique elements found in the array are :
            5
            */
            int n, ctr = 0;
            Console.Write("Input the number of elements to be stored in the array : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int[] arr1 = new int[n];
            int i, j, k;

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            /*Checking duplicate elements in the array */
            Console.Write("\nThe unique elements found in the array are : \n");
            for (i = 0; i < n; i++)
            {
                ctr = 0;
                /*Check duplicate bifore the current position and increase counter by 1 if found.*/
                for (j = 0; j < i - 1; j++)
                {
                    /*Increment the counter when the seaarch value is duplicate.*/
                    if (arr1[i] == arr1[j])
                    {
                        ctr++;
                    }
                }
                /*Check duplicate after the current position and increase counter by 1 if found.*/
                for (k = i + 1; k < n; k++)
                {
                    /*Increment the counter when the seaarch value is duplicate.*/
                    if (arr1[i] == arr1[k])
                    {
                        ctr++;
                    }
                    /* Duplicate numbers next to each other*/
                    if (arr1[i] == arr1[i + 1])
                    {
                        i++;
                    }
                }
                /*Print the value of the current position of the array as unique value when counter remain contains its initial value.*/
                if (ctr == 0)
                {
                    Console.Write("{0} ", arr1[i]);
                }
            }
            Console.Write("\n\n");

        }


        internal static void GetExercise7()
        {
            /*
            7. Write a program in C# Sharp to merge two arrays of same size sorted in ascending order. Go to the editor
                Test Data :
                Input the number of elements to be stored in the first array :3
                Input 3 elements in the array :
                element - 0 : 1
                element - 1 : 2
                element - 2 : 3
                Input the number of elements to be stored in the second array :3
                Input 3 elements in the array:
                element - 0 : 1
                element - 1 : 2
                element - 2 : 3
                Expected Output:
                The merged array in ascending order is :
                1 1 2 2 3 3
            */

            throw new NotImplementedException();
        }

        internal static void GetExercise8()
        {
            throw new NotImplementedException();
        }

        internal static void GetExercise9()
        {
            throw new NotImplementedException();
        }
        internal static void GetExercise10()
        {
            throw new NotImplementedException();
        }



    }
}
