// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;
using System.Security.AccessControl;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro();

            string sentence = "My name is Mustafa Gediz";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is Ahu Eda Gediz";

            bool result3 = sentence.EndsWith("ğ");
            bool result4 = sentence.StartsWith("My name");

            var result5 = sentence.IndexOf("name"); // bir metnin içinde bir ifadeyi aramak içi
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");
            var result8 = sentence.Insert(0, "Hello, ");// bir cümleye vaya ifadeye başka bir metni yerleştirmek için kullanılır
            var result9 = sentence.Substring(3,4);//Bu metni parçalamk için kullanılır
            var result10 = sentence.ToLower();//hepsini küçük karakter
            var result11 = sentence.ToUpper();//hepsini büyük karakter
            var result12 = sentence.Replace(" ", "-");// metin içerisinde belli karakterleri değiştirmek için kullanırız
            var result13 = sentence.Remove(2,5);//bir metinde belli bir bölümü atmak için kullanılır.2 den sonra 5 karakteri uçur :)


            Console.WriteLine(result9);

            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";

            Console.WriteLine(String.Format("{0} {1}",city,city2));
        }
    }

}