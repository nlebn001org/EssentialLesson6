using System;

namespace EssentialLesson6Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 6, 1, 23, 15, 767, 343, 867, 123, 67678, 23, 65, 123, 676, 34, 67 };
            int [] arr2 = AscClass.AscMethod(arr);
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
        }
    }
}
