using Task1_CustomerDataBase;
using Microsoft.EntityFrameworkCore.Storage.Json;
using System;
using System.Security.Cryptography;

public class AddData
{
    public static void Run()
    {
        using (var context = new AppDbContext())
        {
            // Create new address
            var _address = new Address
            {
                Street = "Storgatan 1",
                City = "Stockholm"
            };

            // Add address in DataBase
            context.Addresses.Add(_address);    // the table name is Address

            // Create a new person and link it to the address
            var _customer = new Customer
            {
                Name = "Erik Johansson",
                PhoneNumber = "0739876543",
                Address = _address
            };

            // Add person in DataBase
            context.Customers.Add(_customer);    // the table name is People

            // Save changes
            context.SaveChanges();
            System.Console.WriteLine("Data has been saved in the DataBase.");
        }

    }
}