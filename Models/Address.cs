using System.Collections.Generic;
using Task1_CustomerDataBase;


namespace Task1_CustomerDataBase
{
    public class Address                        // this class is one table
    {
        public int ID { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        // public int ZipCode { get; set; }
        public ICollection<Customer> Customers { get; set; }

    }
}

/*
o Address: 
▪ Id (int, primärnyckel) 
▪ Street (string, obligatorisk) 
▪ City (string, obligatorisk) 
*/