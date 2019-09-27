using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbreGenealogique
{
    class Personne
    {
        private string _nom;
        private string _prenom;
        private Date _dateDeNaissance;
        private Date _dateDeDeces;
        private Personne _pere;
        private Personne _mere;
        private bool _vivant;
        private bool _aUnPere;
        private bool _aUneMere;


        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public Date DateDeNaissance { get => _dateDeNaissance; set => _dateDeNaissance = value; }
        public Date DateDeDeces { get => _dateDeDeces; set => _dateDeDeces = value; }
        public Personne Pere { get => _pere; set => _pere = value; }
        public Personne Mere { get => _mere; set => _mere = value; }
        public bool Vivant { get => _vivant; set => _vivant = value; }
        public bool AUnPere { get => _aUnPere; set => _aUnPere = value; }
        public bool AUneMere { get => _aUneMere; set => _aUneMere = value; }

        public Personne(string nom, string prenom, int jour, int mois, int annee)
        {
            Nom = nom;
            Prenom = prenom;
            DateDeNaissance = new Date(jour, mois, annee);
            Vivant = true;
            AUnPere = false;
            AUneMere = false;
        }
        public void ACommePere(Personne pere)
        {
            Pere = pere;
            AUnPere = true;
        }
        public void ACommeMere(Personne mere)
        {
            Mere = mere;
            AUneMere = true;
        }
        public void Deces(int jour, int mois, int annee)
        {
            DateDeDeces = new Date(jour, mois, annee);
            Vivant = false;
        }
        public void Afficher()
        {
            if (!Vivant)
            Console.WriteLine($"{Prenom} {Nom}\nné(e) le {DateDeNaissance.VersChaine()}\ndécédé(e) le {DateDeDeces.VersChaine()}");
            else
            Console.WriteLine($"{Prenom} {Nom}\nné(e) le {DateDeNaissance.VersChaine()}");
        }
        public void AfficherGenealogie()
        {
            Afficher();
            if (AUnPere)
            {
                Console.WriteLine("\tA comme père :");
                Pere.AfficherGenealogie();
            }
            if (AUneMere)
            {
                Console.WriteLine("\tA comme mère :");
                Mere.AfficherGenealogie();
            }


        }
    }
}
