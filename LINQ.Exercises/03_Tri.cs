
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
            Check.That(result).IsEquivalentTo("apple", "blueberry", "cherry");
        }

        [Fact]
        public void Tri_alphabetique()
        {
            var result = TestData.OrderByWordsExtended;
            Check.That(result).IsEquivalentTo("apple", "blueberry", "cherry", "tamarind", "zuchini");
        }

        [Fact]
        public void Tri_alphabetique_selon_la_deuxieme_lettre()
        {
            var result = TestData.OrderByWordsExtended;

            Check.That(result).IsEquivalentTo("tamarind", "cherry", "blueberry", "apple", "zuchini");
        }

        [Fact]
        public void Tri_alphabetique_descendant()
        {
            var result = TestData.OrderByWordsExtended;

            Check.That(result).IsEquivalentTo("zuchini", "tamarind", "cherry", "blueberry", "apple");
        }

        [Fact]
        public void Tri_par_longueur_de_chaine()
        {
            var result = TestData.OrderByWords;

            Check.That(result).IsEquivalentTo("apple", "cherry", "blueberry");
        }

        [Fact]
        public void Tri_par_nom_de_famille()
        {
            var result = TestData.People;

            Check.That(result).IsEquivalentTo(
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
            // Indice, il existe une classe nommée CaseInsensitiveComparer
            var result = words;

            Check.That(result).IsEquivalentTo("AbAcUs", "aPPLE", "BlUeBeRrY", "bRaNcH", "cHeRry", "ClOvEr");
        }

        [Fact]
        public void Trier_personnes_par_initiales()
        {
            var result = TestData.People;

            Check.That(result).IsEquivalentTo(
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

            var result = doubles;

            Check.That(result).IsEquivalentTo(4.1, 2.9, 2.3, 1.9, 1.7);
        }

        [Fact]
        public void Tri_du_plus_age_au_plus_jeune()
        {
            var result = TestData.People;

            Check.That(result).IsEquivalentTo(
                new TestData.Person("Jean", "Gean", new DateTime(1950, 12, 1)),
                new TestData.Person("Jimmy", "Jilly", new DateTime(1974, 9, 16)),
                new TestData.Person("Jack", "Tuck", new DateTime(1990, 3, 12)),
                new TestData.Person("Jill", "Lill", new DateTime(2001, 5, 21))
            );
        }

        [Fact]
        public void Tri_du_plus_jeune_au_plus_age()
        {
            var result = TestData.People;

            Check.That(result).IsEquivalentTo(
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
            var result = digits;

            Check.That(result).IsEquivalentTo("one", "six", "two", "five", "four", "nine", "zero", "eight", "seven", "three");
        }

        [Fact]
        public void Tri_par_longueur_de_chaine_puis_par_ordre_alphabetique_sans_gerer_la_casse()
        {
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var result = words;

            Check.That(result).IsEquivalentTo("aPPLE", "AbAcUs", "bRaNcH", "cHeRry", "ClOvEr", "BlUeBeRrY");
        }

        [Fact]
        public void Tous_les_chiffres_contenant_la_lettre_i_dans_l_ordre_inverse()
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var result = digits;

            Check.That(result).IsEquivalentTo("nine", "eight", "six", "five");
        }
    }
}
