using System.Linq;

using NFluent;
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
            Check.That(result).ContainsExactly(2, 3, 5);
        }

        [Fact]
        public void Nombres_plus_petits_ou_egaux_a_zero()
        {
            var result = TestData.Numbers.Where(n => n <= 0);

            Check.That(result).ContainsExactly(-3, -1, -4, -1, -5);
        }

        [Fact]
        public void N_fois_2_superieur_a_5()
        {
            var result = TestData.Numbers.Where(n => n * 2 > 5);

            Check.That(result).ContainsExactly(3, 5);
        }

        [Fact]
        public void N_est_pair()
        {
            var result = TestData.Numbers.Where(n => n % 2 == 0);

            Check.That(result).ContainsExactly(2, -4);
        }

        [Fact]
        public void L_index_de_n_est_pair()
        {
            var result = TestData.Numbers.Where((item, index) => index % 2 == 0);

            Check.That(result).ContainsExactly(1, 1, 2, 3, 5);
        }

        [Fact]
        public void N_est_pair_et_plus_petit_que_zero()
        {
            var result = TestData.Numbers.Where(n => n % 2 == 0 && n < 0);

            Check.That(result).ContainsExactly(-4);
        }

        [Fact]
        public void N_au_carre_moins_2_fois_n_est_plus_grand_que_n()
        {
            var result = TestData.Numbers.Where(n => n * n - 2 * n > n);

            Check.That(result).ContainsExactly(-3, -1, -4, -1, 5, -5);
        }

        [Fact]
        public void Chaines_de_longueur_inferieure_a_5()
        {
            var result = TestData.Animals.Where(a => a.Length < 5);

            Check.That(result).ContainsExactly("lion");
        }

        [Fact]
        public void Chaines_de_longueur_9()
        {
            var result = TestData.Animals.Where(n => n.Length == 9);

            Check.That(result).ContainsExactly("swordfish");
        }

        [Fact]
        public void Chaines_commencant_par_s()
        {
            var result = TestData.Animals.Where(a => a.StartsWith("s"));

            Check.That(result).ContainsExactly("swordfish", "shark");
        }

        [Fact]
        public void Chaines_dont_la_deuxieme_lettre_est_un_i()
        {
            var result = TestData.Animals.Where(a => a[1] == 'i');

            Check.That(result).ContainsExactly("tiger", "lion");
        }

        [Fact]
        public void Chaines_contenant_un_e()
        {
            var result = TestData.Animals.Where(a => a.Contains('e'));

            Check.That(result).ContainsExactly("tiger", "penguin", "elephant");
        }

        [Fact]
        public void Chaines_terminant_par_un_t()
        {
            var result = TestData.Animals.Where(a => a.EndsWith("t"));

            Check.That(result).ContainsExactly("elephant");
        }

        [Fact]
        public void Chaines_contenant_la_chaine_io()
        {
            var result = TestData.Animals.Where(a => a.Contains("io"));

            Check.That(result).ContainsExactly("lion");
        }

        [Fact]
        public void Personnes_dont_le_nom_de_famille_et_le_prenom_commencent_par_la_meme_lettre()
        {
            var result = TestData.People.Where(p => p.LastName.First() == p.FirstName.First());

            Check.That(result).ContainsExactly(TestData.People[3]);
        }

        [Fact]
        public void Personnes_nees_avant_1990()
        {
            var result = TestData.People.Where(p => p.Born.Year < 1990);

            Check.That(result).ContainsExactly(TestData.People[1], TestData.People[3]);
        }

        [Fact]
        public void Personnes_nees_un_jour_pair()
        {
            var result = TestData.People.Where(n => n.Born.Day % 2 == 0);

            Check.That(result).ContainsExactly(TestData.People[0], TestData.People[3]);
        }

        [Fact]
        public void Personnes_nees_un_lundi_21()
        {
            var result = TestData.People.Where(n => n.Born.Day == 21 && n.Born.DayOfWeek == DayOfWeek.Monday);

            Check.That(result).ContainsExactly(TestData.People[2]);
        }

        [Fact]
        public void Personnes_ayant_18_ans_ou_plus_en_2000()
        {
            var result = TestData.People.Where(p => 2000 - p.Born.Year >= 18);

            Check.That(result).ContainsExactly(TestData.People[1], TestData.People[3]);
        }

        [Fact]
        public void Personnes_dont_le_nom_de_famille_contient_ll_et_dont_la_somme_jour_mois_annee_est_superieure_a_2000()
        {
            var result = TestData.People
                .Where(p => p.LastName.Contains("ll") && (p.Born.Day + p.Born.Month + p.Born.Year) > 2000);

            Check.That(result).ContainsExactly(TestData.People[2]);
        }
    }
}