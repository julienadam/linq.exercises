﻿using System.Linq;
using NFluent;
using Xunit;

namespace LINQ.Exercises
{
    /// <summary>
    /// L'objectif ici est d'utiliser `First/FirstOrDefault/Last/LastOrDefault`
    /// Inspectez les données situées dans le fichier TestData.cs
    /// Ne modifiez pas les assertions ou les données de test ! Il faut utiliser les méthodes LINQ de manière à ce que 
    /// la variable `result` contienne des données qui passent les tests.
    /// </summary>
    public class Element
    {
        [Fact]
        public void Premier_nombre()
        {
            // Ce test passe pour vous montrer comment procéder
            int result = TestData.Numbers.First();

            Check.That(result).IsEqualTo(1);
        }

        [Fact]
        public void Premier_nombre_plus_petit_que_zero()
        {
            int result = TestData.Numbers.First();

            Check.That(result).IsEqualTo(-3);
        }

        [Fact]
        public void Dernier_nombre_plus_grand_que_0()
        {
            int result = TestData.Numbers.First();

            Check.That(result).IsEqualTo(5);
        }

        [Fact]
        public void Premier_nombre_pair()
        {
            int result = TestData.Numbers.First();

            Check.That(result).IsEqualTo(2);
        }

        [Fact]
        public void Dernier_nombre_pair()
        {
            int result = TestData.Numbers.First();

            Check.That(result).IsEqualTo(-4);
        }

        [Fact]
        public void Premier_nombre_plus_grand_que_10_si_pas_de_resultat_retourner_0()
        {
            int result = TestData.Numbers.First();

            Check.That(result).IsEqualTo(0);
        }

        [Fact]
        public void Dernier_nombre_plus_petit_que_moins_1234_si_pas_de_resultat_retourner_0()
        {
            int result = TestData.Numbers.First();

            Check.That(result).IsEqualTo(0);
        }

        [Fact]
        public void Dernier_elephant()
        {
            string result = TestData.Animals.First();

            Check.That(result).IsEqualTo("elephant");
        }

        [Fact]
        public void Premiere_chaine_de_4_caracteres()
        {
            string result = TestData.Animals.First();

            Check.That(result).IsEqualTo("lion");
        }

        [Fact]
        public void Derniere_chaine_contenant_un_g()
        {
            string result = TestData.Animals.First();

            Check.That(result).IsEqualTo("penguin");
        }

        [Fact]
        public void Premiere_chaine_dont_la_premiere_lettre_est_un_s()
        {
            string result = TestData.Animals.First();

            Check.That(result).IsEqualTo("swordfish");
        }

        [Fact]
        public void Dernier_mot_de_3_lettres_si_pas_de_resultat_retourner_null()
        {
            string result = TestData.Animals.First();

            Check.That(result).IsNull();
        }

        [Fact]
        public void Premiere_personne_nee_apres_2000()
        {
            TestData.Person result = TestData.People.First();

            Check.That(result).IsEqualTo(TestData.People[2]);
        }

        [Fact]
        public void Derniere_personne_dont_le_nom_de_famille_finit_par_un_l()
        {
            TestData.Person result = TestData.People.First();

            Check.That(result).IsEqualTo(TestData.People[2]);
        }

        [Fact]
        public void Premiere_personne_nee_le_141_jour_de_l_annee()
        {
            TestData.Person result = TestData.People.First();

            Check.That(result).IsEqualTo(TestData.People[2]);
        }

        [Fact]
        public void Derniere_personne_dont_le_prenom_ne_commence_pas_par_J_ou_null_si_pas_de_resultat()
        {
            TestData.Person result = TestData.People.First();

            Check.That(result).IsNull();
        }
    }
}