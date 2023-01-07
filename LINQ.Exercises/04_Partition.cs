using System.Collections.Generic;
using System.Linq;
using NFluent;
using Xunit;

namespace LINQ.Exercises
{
    /// <summary>
    /// Utiliser TakeWhile, TakeWhile, Skip, SkipWhile, ou leur version indexée de manière à faire passer les tests.
    /// Inspectez les données situées dans le fichier TestData.cs
    /// Ne modifiez pas les assertions ou les données de test ! Il faut utiliser les méthodes LINQ de manière à ce que 
    /// la variable `result` contienne des données qui passent les tests.
    /// </summary>
    public class Partition
    {
        [Fact]
        public void Les_3_premiers_nombres()
        {
            // Le premier test passe.
            var result = TestData.PartitionNumbers.Take(3);

            Check.That(result).ContainsExactly(5, 4, 1);
        }

        [Fact]
        public void Les_deux_premiers_nombres()
        {
            var result = TestData.PartitionNumbers;

            Check.That(result).ContainsExactly(5, 4);
        }

        [Fact]
        public void Tous_les_nombres_sauf_les_4_premiers()
        {
            var result = TestData.PartitionNumbers;

            Check.That(result).ContainsExactly(9, 8, 6, 7, 2, 0);
        }

        [Fact]
        public void Tous_les_nombres_jusqu_au_premier_nombre_qui_n_est_pas_plus_petit_que_6()
        {
            var result = TestData.PartitionNumbers;

            Check.That(result).ContainsExactly(5, 4, 1, 3);
        }

        [Fact]
        public void Tous_les_nombres_jusqu_au_premier_qui_est_inferieur_a_sa_position_dans_la_sequence()
        {
            var result = TestData.PartitionNumbers;

            Check.That(result).ContainsExactly(5, 4);
        }

        [Fact]
        public void Tous_les_elements_a_partir_du_premier_element_divisible_par_3()
        {
            var result = TestData.PartitionNumbers;

            Check.That(result).ContainsExactly(3, 9, 8, 6, 7, 2, 0);
        }

        [Fact]
        public void Tous_les_elements_a_partir_du_premier_element_inferieur_a_sa_position_dans_la_sequence()
        {
            var result = TestData.PartitionNumbers;

            Check.That(result).ContainsExactly(1, 3, 9, 8, 6, 7, 2, 0);
        }
    }
}