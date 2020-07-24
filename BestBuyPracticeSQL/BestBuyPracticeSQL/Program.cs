using System;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;

namespace BestBuyPracticeSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Configuration
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connString = config.GetConnectionString("DefaultConnection");
            #endregion

            IDbConnection conn = new MySqlConnection(connString);
            DapperDepartmentRepository repo = new DapperDepartmentRepository(conn);
            DapperProductRepository pedo = new DapperProductRepository(conn);


            Console.WriteLine("Current Departments:");
            Console.WriteLine("Please press enter . . .");
            Console.ReadLine();
            var depos = repo.GetAllDepartments();

            foreach (var depo in depos)
            {
                Console.WriteLine($"Id: {depo.departmentid} Name: {depo.name}");
            }

            Console.WriteLine("Would you like to add a department?");
            string response = Console.ReadLine();

            if (response.ToLower() == "yes")
            {
                Console.WriteLine("What is the name of your new Department?");
                response = Console.ReadLine();

                repo.InsertDepartment(response);
            }

            Console.WriteLine("Current Products:");
            Console.WriteLine("Please press enter . . .");
            Console.ReadLine();
            var pedos = pedo.GetAllProducts();

            foreach (var item in pedos)
            {
                Console.WriteLine($"ProductID: {item.ProductID} Name: {item.Name} Price: {item.Price} CategoryID: {item.CategoryID} Onsale: {item.OnSale} StockLevel: {item.StockLevel}");
            }


            Console.WriteLine("Have a good day.");
        }



    }
}
