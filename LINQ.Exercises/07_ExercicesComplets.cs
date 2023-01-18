using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NFluent;
using Xunit;

namespace LINQ.Exercises
{
    /// <summary>
    /// Combinez autant d'opérateurs Linq que nécessaire
    /// Inspectez les données situées dans le fichier TestData.cs
    /// Ne modifiez pas les assertions ou les données de test ! Il faut utiliser les méthodes LINQ de manière à ce que 
    /// la variable `result` contienne des données qui passent les tests.
    /// </summary>
    public class ExercicesComplets
    {
        [Fact]
        public void Trouvez_les_lettres_communes_a_tous_les_prenoms_des_personnes()
        {
            var commonCharacters =
                TestData.People
                    .Select(p => (IEnumerable<char>)p.FirstName)
                    .Aggregate((state, p) => p.Intersect(state));

            Check.That(commonCharacters).ContainsExactly('J');
        }

        [Fact]
        public void Trouvez_les_lettres_communes_a_au_moins_deux_prenoms()
        {
            var commonCharacters =
                TestData.People
                    .SelectMany(p => p.FirstName.Distinct())
                    .GroupBy(c => c)
                    .Where(g => g.Count() >= 2)
                    .Select(g => g.Key);
            
            Check.That(commonCharacters).Contains('a');
            Check.That(commonCharacters).Contains('i');
            Check.That(commonCharacters).Contains('J');
            Check.That(commonCharacters).HasSize(3);
        }

        [Fact]
        public void Les_millionaires_de_chaque_banque_tries_par_balance_descendante()
        {
            var resultats = 
                TestData.Customers
                    .Where(c => c.Balance >= 1_000_000)
                    .OrderByDescending(c => c.Balance)
                    .GroupBy(c => c.Bank);
            
            Check.That(resultats).HasSize(4);
            Check.That(resultats.Single(g => g.Key == "BNP")).ContainsExactly(TestData.Customers[1], TestData.Customers[5]);
            Check.That(resultats.Single(g => g.Key == "SG")).ContainsExactly(TestData.Customers[7]);
            Check.That(resultats.Single(g => g.Key == "CA")).ContainsExactly(TestData.Customers[3]);
            Check.That(resultats.Single(g => g.Key == "LCL")).ContainsExactly(TestData.Customers[8]);
        }

        [Fact]
        public void Trouver_le_caractere_le_plus_frequent()
        {
            var resultat = "49fjs492jfJs94KfoedK0iejksKdsj3".First();

            Check.That(resultat).IsEqualTo('n');
        }

        [Fact]
        public void Calculer_le_produit_des_deux_tableaux_numbers_et_partition_numbers()
        {
            // [1, 2, 3] et [4, 5, 6] donne 1*4 + 2*5 + 3*6 = 32
            var resultat = 0;

            Check.That(resultat).IsEqualTo(-2);
        }

        [Fact]
        public void Melangez_le_tableau_d_animaux_de_maniere_aleatoire()
        {
            var rnd = new Random(123);
            var resultat = TestData.Animals;

            Check.That(resultat).ContainsExactly("shark", "elephant", "swordfish", "penguin", "lion", "tiger");
        }
    }
}