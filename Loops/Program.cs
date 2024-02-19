// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;
using System.Security.AccessControl;

namespace Loops
{
    class Program
    {
        static void Main(string[] args) //veri kümesinde dolaşmak istiyorsunuz. bunun için döngülerden faydalanırsınız.
                                        //veri kümesini dolaşmak için kullandığımız yapılara döngü diyoruz
        {
            //ForLoop();

            //WhileLoop();

            //DoWhlieLoop();

            //ForEachLoop();

            if (IsPrimeNumber(6))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }

            Console.ReadLine();
        }
        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number;

                }
            }
            return result;
        }

        private static void ForEachLoop()
        {
            string[] students = new string[3] { "Mustafa", "Ahu", "Eymen" };
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static void DoWhlieLoop()
        {
            int number = 10;

            do
            {
                Console.WriteLine(number);
                number--;

            } while (number>=11);
        }

        private static void WhileLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
        }

        private static void ForLoop()
        {
            //başlangıç değerimiz int i = 1;
            //şartımız. dönecem ama hagi şarta göre döneceğim i <= 100;
            // i++ her dönüş bittiğinde birer birer arttır.
            //i+=2 bu tek sayılar. i=i+2 ile aynı anlamda
            //for (int i = 2; i <= 100; i+=2) başlangıç degerini 2 yaparsak bu sefer bize çift sayıları verecektir.
            //for (int i = 100; i >= 0; i+=-2)
            for (int i = 1; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished!");
        }
    }

}