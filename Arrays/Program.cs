// See https://aka.ms/new-console-template for more information
namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //string student1 = "Mustafa";
            //string student2 = "Ahu";
            //string student3 = "Eymen";

            string[,] regions = new string[5, 3]
            {
                {"İstanbul", "İzmit", "Balıkesir"},
                {"Ankara", "Konya", "Kırıkkale"},
                {"Antalya", "Adana", "Mersin"},
                {"Rize", "Trabzon", "Samsun"},
                {"İzmir", "Muğla", "Manisa"},
            };
            for (int i = 0; i <= regions.GetUpperBound(0); i++) 
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);   
                }
                Console.WriteLine("*************");
            }


            Console.WriteLine();
            Console.ReadLine();


        }
    }

}