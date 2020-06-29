
using DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ChinookApp
{
    class Program
    {
        public static readonly ILoggerFactory MyLoggerFactory
            = LoggerFactory.Create(builder => { builder.AddConsole(); });

        public static readonly DbContextOptions<ChinookContext> Options = new DbContextOptionsBuilder<ChinookContext>()
            //.UseLoggerFactory(MyLoggerFactory)
            .UseSqlServer(SecretConfiguration.ConnectionString)
            .Options;
        public static List<ExEmployee> employees = new List<ExEmployee>();
        public static ChinookContext context = new ChinookContext(Options);

        static void Main(string[] args)
        {
            employees = context.ExEmployee.ToList();
            

            DisplayData();

            Console.WriteLine("\nAdding some data...");
            AddSomeDataFromUserInput();

            DisplayData();

            //Console.WriteLine("\nUpdating some data...");
            //UpdateSomeData();

            //DisplayData();

            //Console.WriteLine("\nDeleting some data...");
            //DeleteSomeData();

           // DisplayData();


        }

        private static void DeleteSomeData()
        {
            throw new NotImplementedException();
        }

        private static void UpdateSomeData()
        {
            throw new NotImplementedException();
        }

        private static void AddSomeDataFromUserInput()
        {
            Console.Write("Enter a first name: ");
            var input = Console.ReadLine();
            Console.Write("Enter a last name: ");
            var input2 = Console.ReadLine();
            Console.Write("Enter your SSN: ");
            var input3 = Convert.ToInt32(Console.ReadLine());
            var dep = context.Department.Find(2);

            // gets total number of rows in ExEmployee
            var EmployeeCount = context.ExEmployee.Count();
            // creates new ExEmployee Entry
            var recruit = new ExEmployee { Id = EmployeeCount + 1, FirstName = input, LastName = input2, Ssn = input3,  Dept = dep};
            // adds new entry to the Table ExEmployee
            context.Add(recruit);
            employees.Add(recruit);
            context.SaveChanges();
        }

        private static void DisplayData()
        {
            List<Department> departments = context.Department.Include(e => e.ExEmployee).ToList();
            foreach(var D in departments)
            {
                var Ouremployee = D.ExEmployee.Select(e => e.FirstName);
                var employeeString = string.Join(", ", Ouremployee);
                Console.WriteLine($"{D.Name}: {employeeString}");
            }
        }
    }

    internal class SecretConfiguration
    {
        internal const string ConnectionString = "Server = tcp:williams1998.database.windows.net,1433;Initial Catalog = Chinook; Persist Security " +
            "Info=False;User ID = asher; Password=Clarkezlayer571;MultipleActiveResultSets=False;Encrypt=True;" +
            "TrustServerCertificate=False;Connection Timeout = 30";
    }
}
