using System.Diagnostics;
using System.Reflection.Emit;

namespace compare_algorithm
{
    internal class Program
    {

        static void Merge(int[] a, int low, int mid, int high)
        {
            int i, j, k;
            int num1 = mid - low + 1;
            int num2 = high - mid;
            int[] L = new int[num1];
            int[] R = new int[num2];
            for (i = 0; i < num1; i++)
            {
                L[i] = a[low + i];
            }
            for (j = 0; j < num2; j++)
            {
                R[j] = a[mid + j + 1];
            }
            i = 0;
            j = 0;
            k = low;
            while (i < num1 && j < num2)
            {
                if (L[i] <= R[j])
                {
                    a[k] = L[i];
                    i++;
                }
                else
                {
                    a[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < num1)
            {
                a[k] = L[i];
                i++;
                k++;
            }
            while (j < num2)
            {
                a[k] = R[j];
                j++;
                k++;
            }
        }

        static void MergeSortRecursive(int[] a, int low, int high)
        {
            if (low < high)
            {
                int mid = (low + high) / 2;
                MergeSortRecursive(a, low, mid);
                MergeSortRecursive(a, mid + 1, high);
                Merge(a, low, mid, high);
            }
        }
        static int[] CreateArray(int size, Random r)
        {
            int[] array = new int[size];
            //foreach (int i in array)
            for (int i = 0; i < size; i++)
                {
                array[i] = r.Next(1, 10000);
            }
            return array;
        }
        static void menu()
        {
            Console.WriteLine("what would you like to do?");
            Console.WriteLine("1: Linear Search");
            Console.WriteLine("2: Binary Search");
            Console.WriteLine("3: Bubble Sort");
            Console.WriteLine("4: Merge Sort");
            Console.WriteLine("9: Quit");

        }

        static void BubbleSort(int[] a)
        {

        }

        static bool LinearSearch(int[] a, int numToFind)
        {
            bool found = false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == numToFind)
                { 
                    found = true;
                }
            }
            return found;
        }

        static bool BinarySearch(int[] a, int numToFind)
        {
            bool found = false;
            int lowerBound = 0;
            int upperBound = a.GetLength(0) - 1 ;
            while (lowerBound != upperBound || found == false)
            { 

            }
            return found;
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("How many numbers would you like in your array?");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = CreateArray(size, rnd);
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            int choice = 0;
            while (choice != 9 || choice != 1 || choice != 2 || choice != 3 || choice != 4)
            {
                menu();
                Console.WriteLine("enter the number of your choice:");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 9)
                {
                    System.Environment.Exit(0);
                }
                else if (choice == 1)
                {
                    Console.WriteLine("what number would you like to find");
                    int numToFind = Convert.ToInt32(Console.ReadLine());
                    bool found = LinearSearch(array, numToFind);
                    if (found == true)
                    {
                        Console.WriteLine($"{numToFind} was found in the array");
                    }
                    else
                    {
                        Console.WriteLine($"{numToFind} was not found in the array");
                    }
                }
                else if(choice == 2)
                {
                    Console.WriteLine("what number would you like to find");
                    int numToFind = Convert.ToInt32(Console.ReadLine());
                    bool found = LinearSearch(array, numToFind);
                    BinarySearch(array, numToFind);
                }
                else if(choice == 3)
                {
                    BubbleSort(array);
                }
                //else if (choice == 4)
                //{
                //    MergeSortRecursive(array, );
                //}
            }
        }


    }
}
