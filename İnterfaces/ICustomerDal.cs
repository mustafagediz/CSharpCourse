﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterfaces
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added!");
        }

        public void Update()
        {
            Console.WriteLine("Sql Update!");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Added!");
        }
    }

    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added!");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Update!");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Added!");
        }

        
    }
    class MySqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql Added!");
        }

        public void Update()
        {
            Console.WriteLine("MySql Update!");
        }

        public void Delete()
        {
            Console.WriteLine("MySql Added!");
        }


    }
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }

}
