using Microsoft.EntityFrameworkCore;
using System;
using Task1_CustomerDataBase;
using System.Linq;

public class ReadData
{
    public static void Run()
    {
        
        using (var context = new AppDbContext())
        {
            var _customer = context.Customers
            .Include(c => c.Address)   // include relation to address
            .ToList();
            // Check
            if (_customer.Any())
            {
                foreach (var item in _customer)
                {
                    System.Console.WriteLine($"Name: {item.Name}, PhoneNumber: {item.PhoneNumber}, Address: {item.Address.Street}, City: {item.Address.City}");
                }
            }
            else
            {
                System.Console.WriteLine("No match in the DataBase!");
            }
        }
    }
}