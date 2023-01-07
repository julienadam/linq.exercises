using System.Linq;
using Xunit;

namespace LINQ.Exercises
{
    /// <summary>
    /// Utiliser Where pour filtrer de manière à faire passer les tests
    /// Inspectez les données situées dans le fichier TestData.cs
    /// Ne modifiez pas les assertions ou les données de test ! Il faut utiliser les méthodes LINQ de manière à ce que 
    /// la variable `result` contienne des données qui passent les tests.
    /// </summary>
    public class Filtrage
    {
        [Fact]
        public void Nombres_plus_grands_que_1()
        {
            // Ce premier test passe
            var result = TestData.Numbers.Where(n => n > 1);

            Assert.Equal(3, result.Count());
        }

        [Fact]
        public void Nombres_plus_petits_ou_egaux_a_zero()
        {
            var result = TestData.Numbers.Where(n => n <= 0);

            Assert.Equal(new[] { -3, -1, -4, -1, -5 }, result);
        }

        [Fact]
        public void N_fois_2_superieur_a_50()
        {
            var result = TestData.Numbers;

            Assert.Equal(new[] { 3, 5 }, result);
        }

        [Fact]
        public void N_est_pair()
        {
            var result = TestData.Numbers;

            Assert.Equal(new[] { 2, -4 }, result);
        }

        [Fact]
        public void L_index_de_n_est_impair()
        {
            var result = TestData.Numbers;

            Assert.Equal(new[] { 1, 1, 3, 5 }, result);
        }

        [Fact]
        public void N_est_impair_et_plus_petit_que_zero()
        {
            var result = TestData.Numbers;

            Assert.Equal(new[] { -4 }, result);
        }

        [Fact]
        public void N_au_carre_moins_2_fois_n_est_plus_grand_que_n()
        {
            var result = TestData.Numbers;

            Assert.Equal(new[] { -3, -1, -4, -1, 5, -5 }, result);
        }

        [Fact]
        public void Chaines_de_longueur_inferieure_a_5()
        {
            var result = TestData.Animals;

            Assert.Equal(new[] { "lion" }, result);
        }

        [Fact]
        public void Chaines_de_longueur_9()
        {
            var result = TestData.Animals;

            Assert.Equal(new[] { "swordfish" }, result);
        }

        [Fact]
        public void Chaines_commencant_par_s()
        {
            var result = TestData.Animals;

            Assert.Equal(new[] { "swordfish", "shark" }, result);
        }

        [Fact]
        public void Chaines_dont_la_deuxieme_lettre_est_un_i()
        {
            var result = TestData.Animals;

            Assert.Equal(new[] { "tiger", "lion" }, result);
        }

        [Fact]
        public void Chaines_contenant_un_e()
        {
            var result = TestData.Animals;

            Assert.Equal(new[] { "tiger", "penguin", "elephant" }, result);
        }

        [Fact]
        public void Chaines_terminant_par_un_t()
        {
            var result = TestData.Animals;

            Assert.Equal(new[] { "elephant" }, result);
        }

        [Fact]
        public void Chaines_contenant_la_chaine_io()
        {
            var result = TestData.Animals;

            Assert.Equal(new[] { "lion" }, result);
        }

        [Fact]
        public void Personnes_dont_le_nom_de_famille_et_le_prenom_commencent_par_la_meme_lettre()
        {
            var result = TestData.People;

            Assert.Equal(new[] { TestData.People[3] }, result);
        }

        [Fact]
        public void Personnes_nees_apres_1990()
        {
            var result = TestData.People;

            Assert.Equal(new[] { TestData.People[1], TestData.People[3] }, result);
        }

        [Fact]
        public void Personnes_nees_un_jour_pair()
        {
            var result = TestData.People;

            Assert.Equal(new[] { TestData.People[0], TestData.People[3] }, result);
        }

        [Fact]
        public void Personnes_nees_un_lundi_21()
        {
            var result = TestData.People;

            Assert.Equal(new[] { TestData.People[2] }, result);
        }

        [Fact]
        public void Personnes_ayant_18_ans_ou_plus_en_2000()
        {
            var result = TestData.People;

            Assert.Equal(new[] { TestData.People[1], TestData.People[3] }, result);
        }

        [Fact]
        public void Personnes_dont_le_nom_de_famille_contient_ll_et_dont_la_somme_jour_moi_annee_est_superieure_a_2000()
        {
            var result = TestData.People;

            Assert.Equal(new[] { TestData.People[2] }, result);
        }
    }
}