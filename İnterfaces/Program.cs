using System.Reflection.Metadata.Ecma335;
using İnterfaces;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //soyut nesneleri new lememiz mümkün değildir.

            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }


            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();   
            //manager.Add(new Customer{Id = 2, FirstName = "Eymen", LastName = "Gediz", Address = "Konya"});

            Customer customer = new Customer
            {
                Id = 2,
                FirstName = "Eymen",
                LastName = "Gediz",
                Address = "Konya"
            };

            Student student = new Student
            {
                Id = 3,
                FirstName = "Ezo",
                LastName = "Zengin",
                Departmant = "Computer Sciences"

            };

            manager.Add(student);
            manager.Add(customer);
        }
    }
    //soyut nesneler
    interface IPerson//interface lerin en büyük kullanım amacı bir temel nesne oluşturup bütün nesneleri ondan implement.. etmektir :)
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }

    // somut nesneler
    class Customer:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
    }

    class Worker:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }
    class Student:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}