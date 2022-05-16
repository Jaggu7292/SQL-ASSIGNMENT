using System;
using System;
namespace sample
{
    class array
    {
        static void Main(string[] args)
        {
            // Creating an array  
            int[] arr = new int[6] { 4,6,24,27,3,8 };
             
            int[] arr2 = new int[6];
            
            Console.WriteLine("length of first array: " + arr.Length);
           
            Array.Sort(arr);
            Console.Write("First array elements: ");
           
            PrintArray(arr);
              
            Console.WriteLine("\nIndex position of 27 is " + Array.IndexOf(arr, 27));

           
            Array.Copy(arr, arr2, arr.Length);
            Console.Write("Second array elements: ");
          

  
            PrintArray(arr2);
            Array.Reverse(arr);
            Console.Write("\nFirst Array elements in reverse order: ");
            PrintArray(arr);
        }
         
        static void PrintArray(int[] arr)
        {
            foreach (Object elem in arr)
            {
                Console.Write(elem + " ");
            }
        }
    }
}