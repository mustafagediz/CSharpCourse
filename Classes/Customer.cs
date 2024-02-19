using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{ 
    class Customer
    {
        //property  // bir nesnenin özellliklerle kullanılması
        public int Id { get; set; }// bir müşterinin özelliklerini tutmak için kullandığımız nesnedir.(Property)
        public string FirstName { get; set; }//public string FirstName; arasındaki fark? 
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
