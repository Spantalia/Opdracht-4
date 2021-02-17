using System;

namespace Opdracht_4
{
    class Program
    {

        static void Main(string[] args)
        {
            Random rnd = new Random();

            int[] array1 = new int[10];
            int[] array2 = new int[10];
            int[] array3 = new int[10];

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = GenerateRandomNumber(rnd);
                array2[i] = GenerateRandomNumber(rnd);
                array3[i] = array1[i] + array2[i];
            }

            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(array1[i] + "\t");
            }

            Console.WriteLine();

            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(array2[i] + "\t");
            }

            Console.WriteLine();

            for (int i = 0; i < array3.Length; i++)
            {
                Console.Write(array3[i] + "\t");
            }
        }
        //returnType MethodeNaam(param1, param2)
        private static int GenerateRandomNumber(Random rnd)
        {
            return rnd.Next(10, 99);
        }

    }
}