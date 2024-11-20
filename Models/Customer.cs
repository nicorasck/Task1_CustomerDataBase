using System.ComponentModel.DataAnnotations.Schema;
using Task1_CustomerDataBase;

namespace Task1_CustomerDataBase
{
    public class Customer                           // this class is one table
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        
        [ForeignKey("Address")]                     // connecting to our separate class 'Address'
        public int AddressId { get; set; }
        public Address Address { get; set; }

    }
}




/*
o Customer: 
▪ Id (int, primärnyckel) 
▪ Name (string, obligatorisk) 
▪ PhoneNumber (string, valfri) 
▪ AddressId (int, främmande nyckel) 
*/