using System;
using System.Collections.Generic;

namespace LINQ.Exercises
{
    /// <summary>
    /// Données de test
    /// NE PAS MODIFIER !!!
    /// L'ordre est important
    /// </summary>
    public static class TestData
    {
        public static IEnumerable<int> Numbers
        {
            get
            {
                return new[] { 1, -3, 1, -1, 2, -4, 3, -1, 5, -5 };
            }
        }

        public static ICollection<string> Animals
        {
            get
            {
                return new[] { "tiger", "lion", "swordfish", "penguin", "elephant", "shark" };
            }
        }

        public static IList<Person> People
        {
            get
            {
                return new[]
                {
                    new Person("Jack", "Tuck", new DateTime(1990, 3, 12)),
                    new Person("Jean", "Gean", new DateTime(1950, 12, 1)),
                    new Person("Jill", "Lill", new DateTime(2001, 5, 21)),
                    new Person("Jimmy", "Jilly", new DateTime(1974, 9, 16)),
                };
            }
        }

        public record Customer
        {
            public string Name { get; init; } = "";
            public double Balance { get; init; }
            public string Bank { get; init; } = "";
        }

        public class Person
        {
            public string FirstName { get; }

            public string LastName { get; }

            public DateTime Born { get; }

            public Person(string firstname, string lastname, DateTime born)
            {
                this.FirstName = firstname ?? string.Empty;
                this.LastName = lastname ?? string.Empty;
                this.Born = born;
            }

            public override string ToString()
            {
                return $"{{ {FirstName} {LastName}; {Born:yyyy-MM-dd} }}";
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(FirstName, LastName, Born);
            }

            public override bool Equals(object? obj)
            {
                if (obj is not Person person)
                {
                    return false;
                }

                return FirstName.Equals(person.FirstName) && LastName.Equals(person.LastName) && Born.Equals(person.Born);
            }
        }

        public static IEnumerable<int> PartitionNumbers
        {
            get
            {
                return new[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            }
        }

        public static IEnumerable<string> OrderByWords
        {
            get { return new[] { "cherry", "apple", "blueberry" }; }
        }

        public static IEnumerable<string> OrderByWordsExtended
        {
            get { return new[] { "cherry", "apple", "blueberry", "tamarind", "zuchini" }; }
        }

        private static readonly List<Customer> customers = new()
        {
            new Customer { Name = "Bob Lesman",   Balance = 80_345.66,     Bank = "SG" },
            new Customer { Name = "Joe Landy",    Balance = 9_284_756.21,  Bank = "BNP" },
            new Customer { Name = "Meg Ford",     Balance = 487_233.01,    Bank = "CA" },
            new Customer { Name = "Peg Vale",     Balance = 7_001_449.92,  Bank = "CA" },
            new Customer { Name = "Mike Johnson", Balance = 790_872.12,    Bank = "BNP" },
            new Customer { Name = "Les Paul",     Balance = 8_374_892.54,  Bank = "BNP" },
            new Customer { Name = "Sid Crosby",   Balance = 957_436.39,    Bank = "SG" },
            new Customer { Name = "Sarah Ng",     Balance = 56_562_389.85, Bank = "SG" },
            new Customer { Name = "Tina Fey",     Balance = 1_000_000.00,  Bank = "LCL" },
            new Customer { Name = "Sid Brown",    Balance = 49_582.68,     Bank = "LCL" },
        };

        public static IList<Customer> Customers => customers;
    }
}