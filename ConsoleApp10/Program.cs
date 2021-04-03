using System;


namespace ConsoleApp10
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];

            Console.WriteLine("Введите значение");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a.Length; i++)
            {
                //fix

                Console.WriteLine("Вы ввели: " + a[i]);
            }
        }
    }
}
