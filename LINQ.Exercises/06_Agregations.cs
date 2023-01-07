using System;
using System.Linq;

using NFluent;
using Xunit;

namespace LINQ.Exercises
{
    /// <summary>
    /// Utiliser Count, Sum, Min, Max, Average, Aggregate etc. de manière à faire passer les tests.
    /// Inspectez les données situées dans le fichier TestData.cs
    /// Ne modifiez pas les assertions ou les données de test ! Il faut utiliser les méthodes LINQ de manière à ce que 
    /// la variable `result` contienne des données qui passent les tests.
    /// </summary>
    public class Agregations
    {
        [Fact]
        public void Nombre_d_elements_dans_la_liste_de_nombres()
        {
            // First test is solved to show you how to use these exercises.
            int result = TestData.Numbers.Count();

            Check.That(result).IsEqualTo(10);
        }

        [Fact]
        public void Nombre_d_occurences_de_1()
        {
            int result = TestData.Numbers.Count();

            Check.That(result).IsEqualTo(2);
        }

        [Fact]
        public void Nombre_d_animaux_dont_le_nom_fait_5_lettres()
        {
            int result = TestData.Animals.Count();

            Check.That(result).IsEqualTo(2);
        }

        [Fact]
        public void Somme_des_nombres()
        {
            int result = TestData.Numbers.Count();

            Check.That(result).IsEqualTo(-2);
        }

        [Fact]
        public void Somme_des_longueurs_des_noms()
        {
            int result = TestData.Animals.Count();

            Check.That(result).IsEqualTo(38);
        }

        [Fact]
        public void Somme_des_annees_de_naissance()
        {
            int result = TestData.People.Count();

            Check.That(result).IsEqualTo(7915);
        }

        [Fact]
        public void Nombre_le_plus_petit()
        {
            int result = TestData.Numbers.Count();

            Check.That(result).IsEqualTo(-5);
        }

        [Fact]
        public void Longueur_de_chaine_minimale()
        {
            int result = TestData.Animals.Count();

            Check.That(result).IsEqualTo(4);
        }

        [Fact]
        public void Animal_dont_le_nom_est_le_plus_long()
        {
            string result = TestData.Animals.First();

            Check.That(result).IsEqualTo("swordfish");
        }

        [Fact]
        public void Personne_la_plus_agee()
        {
            var result = TestData.People.First();

            Check.That(result).IsEqualTo(new TestData.Person("Jean", "Gean", new DateTime(1950, 12, 1)));
        }

        [Fact]
        public void Nombre_le_plus_grand()
        {
            int result = TestData.Numbers.Count();

            Check.That(result).IsEqualTo(5);
        }

        [Fact]
        public void Longueur_de_nom_d_animal_la_plus_grande()
        {
            int result = TestData.Animals.Count();

            Check.That(result).IsEqualTo(9);
        }

        [Fact]
        public void Personne_la_plus_jeune()
        {
            var result = TestData.People.First();

            Check.That(result).IsEqualTo(new TestData.Person("Jill", "Lill", new DateTime(2001, 5, 21)));
        }

        [Fact]
        public void Moyenne_des_nombres()
        {
            double result = TestData.Numbers.Count();

            Check.That(result).IsEqualTo(-0.2);
        }

        [Fact]
        public void Moyenne_des_annéees_de_naissance()
        {
            double result = TestData.People.Count();

            Check.That(result).IsEqualTo(1978.75);
        }

        [Fact]
        public void Produit_de_tous_les_nombres()
        {
            int result = TestData.Numbers.First();

            Check.That(result).IsEqualTo(-1800);
        }

        [Fact]
        public void Formule_secrete()
        {
            // Utiliser Aggregate
            // La formule secrète est calculée de la manière suivante :
            // On commence à 256
            // Pour chaque personne, prendre le jour de naissance
            // Si le jour est supérieur à 15, soustraire 10
            // Sinon, ajouter 5
            // Ajouter le résultat au total
            int result = TestData.People.Aggregate(0, (sum, person) => 1);

            Check.That(result).IsEqualTo(296);
        }
    }
}