using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace csvtest
{

    class Program
    {
        public static IConfigurationRoot Configuration;

        static void Main(string[] args)
        {
            Console.WriteLine("Start csv import");

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            Configuration = builder.Build();

            var connectionString = Configuration.GetConnectionString("DefaultConnection");
            Console.WriteLine(connectionString);
            var db = new CsvDbContext();
            db.Database.EnsureCreated();

            // var people = new List<Person>
            // {
            // new Person(1, "paul", "taylor", new Address("st ives","australia")),
            // new Person(2, "john", "smith", new Address("city2","country2"))
            // };

            // var writer = new CsvWriter<Person>();
            // writer.Write(people, "export-example.csv");

            var reader = new CsvReader<Person>();
            var persons = reader.Read("import-example.csv", false);
            foreach (var person in persons)
            {
                Console.WriteLine(person);
                db.Persons.Add(person);
            }
            db.SaveChanges();
        }
    }
}
