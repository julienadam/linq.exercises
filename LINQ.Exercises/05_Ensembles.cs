
using NFluent;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LINQ.Exercises
{
    /// <summary>
    /// Utiliser Distinct, Union, Intersect, Except, OrderBy etc. de manière à faire passer les tests.
    /// Inspectez les données situées dans le fichier TestData.cs
    /// Ne modifiez pas les assertions ou les données de test ! Il faut utiliser les méthodes LINQ de manière à ce que 
    /// la variable `result` contienne des données qui passent les tests.
    /// </summary>
    public class Ensembles
    {
        [Fact]
        public void Entiers_distincts()
        {
            int[] nombres = { 2, 2, 3, 5, 5, 2, 3, 4, 6, 4, 3, 8, 7, 5, 9, 4, 6, 3, 6, 34, 2, 2, 5, 7, 5, 4, 2, 6, 67, 5 };
            var result = nombres;
            
            Check.That(result).ContainsExactly(2, 3, 5, 4, 6, 8, 7, 9, 34, 67);
        }

        [Fact]
        public void Nombres_uniques_issus_des_deux_listes_tries_par_valeur()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

           var result = numbersA;

            Check.That(result).ContainsExactly(0, 1, 2, 3, 4, 5, 6, 7, 8, 9);
        }

        [Fact]
        public void Nombres_communs_entre_les_deux_listes()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            var result = numbersA;

            Check.That(result).ContainsExactly(5, 8);
        }
               
        [Fact]
        public void Nombres_presents_dans_A_mais_pas_dans_B()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            var result = numbersA;

            Check.That(result.Order()).ContainsExactly(0, 2, 4, 6, 9);
        }

        [Fact]
        public void Chaines_presentes_dans_A_mais_pas_dans_B()
        {
            string[] lettersA = { "a", "b", "c", "d", "e" };
            string[] lettersB = { "a", "c", "e" };

           var result = lettersA;

            Check.That(result.Order()).ContainsExactly("b", "d");
        }
    }
}