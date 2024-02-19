// See https://aka.ms/new-console-template for more information
namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();
            //var result = Add2(20, 30);
            //int number1 = 20; //değer tiplerde mevzu tamamen değişkenin değeri ile ilgilenir.
            //int number2 = 100;

            //var result2 = Add3(ref number1, number2); //ref yazdığımız da methoddakini referans alır ve sonuç 20 de 30 çıkar

            //Console.WriteLine(result2);

            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(3, 5, 9));
            Console.WriteLine(Add4(1,2,6,7));

            Console.ReadLine();
        }
        //bir işlemi bir daha kullanacağımız zman aynı metodu kullanarak tek bir yerden kontrol etmiş oluyoruz

        static void Add() //metod bu. metodun ismi de add.. kendini tekrarlama
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int number1, int number2 = 30) //void git şunu yap demek. bir işlem yap demek... eğer number2 verilmezse default olarak bir değer atayabiliyoruz. 
                                                       //default değerleri her zman methodun en sonunda olması gerekir. tutup 0. sıradakine default değeri veremiyoruz
        {
            var result = number1 + number2;
            return result;
        }

        static int Add3(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;

        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        //static //int Multiply(int number1, int number2) metodun imzası
        //    {
        //        return number1 * number2;
        //    }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        static int Add4(params int[] numbers  ) 
        {
            return numbers.Sum();
        }
    }
}
