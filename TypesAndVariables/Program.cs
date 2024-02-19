namespace TypesAndVariables;

public class Program
{
    public static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        //Değer tipleri Value  Types
        //tipi değişken = değeri

        double number5 = 10.4; //64bit
        decimal number6 = 10.4m;

        char character = 'A';
        bool condition = false;//mantıksal değer
        byte number4 = 255;
        short number3 = 32767;// 8bit
        int number1 = 10; //214483648  32bit
        long number2 = 9223372036854775807; //64bit
        var number7 = 10;


        Console.WriteLine("Number1 is {0}", number1);
        Console.WriteLine("Number2 is {0}", number2);
        Console.WriteLine("Number3 is {0}", number3);
        Console.WriteLine("Number4 is {0}", number4);
        Console.WriteLine("Character is:{0}", (int)character);

        Console.ReadLine();
    }
    enum Days
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }

}