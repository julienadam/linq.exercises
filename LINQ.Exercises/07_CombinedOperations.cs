using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LINQ.Exercises
{
    /// <summary>
    /// These tests require the combination of various linq methods to arrive at a solution.
    /// Hints as to what these methods are will not be given. The student is required to think 
    /// critically above the problem in hand, and to utilize the full gamut of all the methods
    /// available to him or her.
    /// </summary>
    public class CombinedOperations
    {
        // we have a list of people
        // we have their first names
        // i need you to find out which letters are common
        // to all the first names

        // Hint: try to use set operations.
        // There are many ways to solve this.
        [Fact]
        public void GetCharactersCommonToEveryonesFirstNamesUsingSetElements_ReturnCharEnumerable()
        {
            List<char> commonCharacters = new List<char>(); // please edit/complete so that the test passes

            Assert.True(commonCharacters.OrderBy(x => x).SequenceEqual(new[] { 'a', 'i', 'J' }.OrderBy(x => x)));
        }

        // Bonus Question
        // we have a list of people
        // we have their first names
        // i need you to find out which letters are common
        // to all the first names names
        // But you are not allowed to use set operations.
        [Fact]
        public void GetCharactersCommonToEveryonesFirstNamesNotUsingSetOperations_ReturnCharEnumerable()
        {
            IEnumerable<char> result = new List<char>();

            Assert.True(result.OrderBy(x => x).SequenceEqual(new[] { 'a', 'i', 'J' }.OrderBy(x => x)));
        }

    }
}
