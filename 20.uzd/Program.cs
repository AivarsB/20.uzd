using System;

namespace _20.uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 7, 4, 7, 3, 6, 9, 2 };
            //Console.WriteLine(numbers[3]);
            //numbers[3] = 10;
            //Console.WriteLine(numbers[3]);

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 3)
                {
                    Console.WriteLine($"Index {i}, value {numbers[i]}");
                    numbers[i] = 10;
                    Console.WriteLine($"Index {i}, new value {numbers[i]}");
                }
            }

        }
    }
}
// Izveidot console aplikāciju, kurā ir int masīvs ar vērtībām 7, 4, 7, 3, 6, 9, 2. 
// Samainīt elementu, kura sākotnējā vērtība ir 3 uz 10.