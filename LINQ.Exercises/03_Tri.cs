
using NFluent;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LINQ.Exercises
{
    /// <summary>
    /// Utiliser OrderBy, OrderByDescending, ThenBy, and ThenByDescending et Reverse pour trier de manière à faire passer les tests.
    /// Vous devrez parfois fournir un comparateur personalisé
    /// Inspectez les données situées dans le fichier TestData.cs
    /// Ne modifiez pas les assertions ou les données de test ! Il faut utiliser les méthodes LINQ de manière à ce que 
    /// la variable `result` contienne des données qui passent les tests.
    /// </summary>
    public class Tri
    {
        [Fact]
        public void Tri_alphabetique_sur_3_mots()
        {
            // Le premier test passe
            var result = TestData.OrderByWords.Order();
            Check.That(result).ContainsExactly("apple", "blueberry", "cherry");
        }

        [Fact]
        public void Tri_alphabetique()
        {
            var result = TestData.OrderByWordsExtended.Order();
            Check.That(result).ContainsExactly("apple", "blueberry", "cherry", "tamarind", "zuchini");
        }

        [Fact]
        public void Tri_alphabetique_selon_la_deuxieme_lettre()
        {
            var result = TestData.OrderByWordsExtended.OrderBy(x => x[1]);

            Check.That(result).ContainsExactly("tamarind", "cherry", "blueberry", "apple", "zuchini");
        }

        [Fact]
        public void Tri_alphabetique_descendant()
        {
            var result = TestData.OrderByWordsExtended.OrderDescending();

            Check.That(result).ContainsExactly("zuchini", "tamarind", "cherry", "blueberry", "apple");
        }

        [Fact]
        public void Tri_par_longueur_de_chaine()
        {
            var result = TestData.OrderByWords.OrderBy(f => f.Length);

            Check.That(result).ContainsExactly("apple", "cherry", "blueberry");
        }

        [Fact]
        public void Tri_par_nom_de_famille()
        {
            var result = TestData.People.OrderBy(p => p.LastName);

            Check.That(result).ContainsExactly(
                new TestData.Person("Jean", "Gean", new DateTime(1950, 12, 1)),
                new TestData.Person("Jimmy", "Jilly", new DateTime(1974, 9, 16)),
                new TestData.Person("Jill", "Lill", new DateTime(2001, 5, 21)),
                new TestData.Person("Jack", "Tuck", new DateTime(1990, 3, 12))
            );
        }

         [Fact]
        public void Tri_alphabetique_sans_prendre_encompte_la_casse()
        {
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            // Indice, utiliser StringComparer.InvariantCultureIgnoreCase
            var result = words.Order(StringComparer.InvariantCultureIgnoreCase);

            Check.That(result).ContainsExactly("AbAcUs", "aPPLE", "BlUeBeRrY", "bRaNcH", "cHeRry", "ClOvEr");
        }

        [Fact]
        public void Trier_personnes_par_initiales()
        {
            var result = TestData.People.OrderBy(p => p.FirstName.First()).ThenBy(p => p.LastName.First());

            Check.That(result).ContainsExactly(
                new TestData.Person("Jean", "Gean", new DateTime(1950, 12, 1)),
                new TestData.Person("Jimmy", "Jilly", new DateTime(1974, 9, 16)),
                new TestData.Person("Jill", "Lill", new DateTime(2001, 5, 21)),
                new TestData.Person("Jack", "Tuck", new DateTime(1990, 3, 12))
            );
        }

        [Fact]
        public void Tri_par_ordre_descendant()
        {
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };

            var result = doubles.OrderDescending();

            Check.That(result).ContainsExactly(4.1, 2.9, 2.3, 1.9, 1.7);
        }

        [Fact]
        public void Tri_du_plus_age_au_plus_jeune()
        {
            var result = TestData.People.OrderBy(p => p.Born);

            Check.That(result).ContainsExactly(
                new TestData.Person("Jean", "Gean", new DateTime(1950, 12, 1)),
                new TestData.Person("Jimmy", "Jilly", new DateTime(1974, 9, 16)),
                new TestData.Person("Jack", "Tuck", new DateTime(1990, 3, 12)),
                new TestData.Person("Jill", "Lill", new DateTime(2001, 5, 21))
            );
        }

        [Fact]
        public void Tri_du_plus_jeune_au_plus_age()
        {
            var result = TestData.People.OrderByDescending(p => p.Born);

            Check.That(result).ContainsExactly(
                new TestData.Person("Jill", "Lill", new DateTime(2001, 5, 21)),
                new TestData.Person("Jack", "Tuck", new DateTime(1990, 3, 12)),
                new TestData.Person("Jimmy", "Jilly", new DateTime(1974, 9, 16)),
                new TestData.Person("Jean", "Gean", new DateTime(1950, 12, 1))
            );
        }

        [Fact]
        public void Tri_par_longeur_de_chaine_puis_par_ordre_alphabetique()
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var result = digits.OrderBy(d => d.Length).ThenBy(d => d);

            Check.That(result).ContainsExactly("one", "six", "two", "five", "four", "nine", "zero", "eight", "seven", "three");
        }

        [Fact]
        public void Tri_par_longueur_de_chaine_puis_par_ordre_alphabetique_sans_gerer_la_casse()
        {
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var result = words.OrderBy(f => f.Length).ThenBy(f => f, StringComparer.InvariantCultureIgnoreCase);

            Check.That(result).ContainsExactly("aPPLE", "AbAcUs", "bRaNcH", "cHeRry", "ClOvEr", "BlUeBeRrY");
        }

        [Fact]
        public void Tous_les_chiffres_contenant_la_lettre_i_dans_l_ordre_inverse()
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var result = digits.Where(d => d.Contains('i')).Reverse();

            Check.That(result).ContainsExactly("nine", "eight", "six", "five");
        }
    }
}
