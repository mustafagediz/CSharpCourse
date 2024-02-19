// See https://aka.ms/new-console-template for more information
namespace Arrays
{
    class Program //class ların tek başına bir anlamaı vardır.. ancak interface lerin tek başına bir anlamı yoktur.
                    // interface de classlara birden çok atama yapabilirken inheritance da sadece bir çoçuğun bir babası olur.
                    // yani class ın yanına sadece bir tane inheritance tanımlayabiliriz
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer { FirstName = "Mıstafa" }, new Student { FirstName = "Ahmet" },
                new Person { FirstName = "Yasin" }
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    class Customer:Person
    {
        public string City { get; set; }
    }

    class Student:Person
    {
        public string Departman { get; set; }
    }

}
