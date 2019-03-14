using System;

namespace cs_lab1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Type a number");
            string numb = Console.ReadLine();
            int number = Convert.ToInt32(numb);
            int outn = Kube(number);
            Console.WriteLine($"Число {numb}, возведённое в 3 степень: {outn}");
            Console.ReadKey();
        }
        static int Kube(int number) {
            int knumb = number * number * number;
            return knumb;
        }
    }
}
