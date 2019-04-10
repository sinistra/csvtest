using System;
using System.Collections.Generic;

namespace csvtest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start csv import");
            // var a = new Person(1, "\"Hello\", world!", "İĞÜÇÖıüşöç", new Address("city1", "country1"));
            // Console.WriteLine(a.ToCsv());
            // Console.ReadLine();

            // var p = new Person(1, "firstname", "lastname", new Address("city1", "country1"));
            // Console.WriteLine("Ignore by property name:");
            // Console.WriteLine("Ignoring Id property: "
            // + p.ToCsv(new[] { "Id" }, true));
            // Console.WriteLine("Ignoring Name property: "
            // + p.ToCsv(new[] { "Name" }, true));
            // Console.WriteLine("Ignoring Lastname property: "
            // + p.ToCsv(new[] { "Lastname" }, true));
            // Console.WriteLine("Ignore by property index:");
            // Console.WriteLine("Ignoring 0->Id and 2->Lastname: "
            // + p.ToCsv(new[] { 0, 2 }, true));
            // Console.WriteLine("Ignoring everything but Id: "
            // + p.ToCsv(new[] { "Id" }, false));
            // Console.ReadLine();

            var people = new List<Person>
            {
                new Person(1, "paul", "taylor", new Address("st ives","australia")),
                new Person(2, "john", "smith", new Address("city2","country2"))
            };

            var writer = new CsvWriter<Person>();
            writer.Write(people, "export-example.csv");

            var reader = new CsvReader<Person>();
            var persons = reader.Read("import-example.csv", false);
            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }

        }
    }
}
