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
    }
}