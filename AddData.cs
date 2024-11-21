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

            var transaction = context.Database.BeginTransaction();

            try
            {
                var _address = new Address
                {
                    Street = "Malmskilnadsgatan 69",
                    City = "Stockholm"
                };

                context.Addresses.Add(_address);

                var customer1 = new Customer
                {
                    Name = "Ashooka Bazooka",
                    PhoneNumber = "0745875608",
                    Address = _address
                };

                var customer2 = new Customer
                {
                    Name = "Jojje Boy",
                    PhoneNumber = "0745875643",
                    Address = _address
                };

                context.Customers.Add(customer1);
                context.Customers.Add(customer2);

                context.SaveChanges();
                transaction.Commit();
                System.Console.WriteLine("Saved changes");
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                System.Console.WriteLine("Ops! An error occurred: " + ex.Message);
            }

        }
    }
}