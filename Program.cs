using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbreGenealogique
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne jean = new Personne("Dupond", "Jean", 3, 1, 1966);
            Personne marie = new Personne("Durand", "Marie", 5, 9, 1942);
            Personne marcel = new Personne("Dupond", "Marcel", 15, 10, 1938);
            Personne helene = new Personne("Leblanc", "Hélène", 21, 11, 1908);
            Personne paul = new Personne("Durand", "Paul", 12, 06, 1905);

            helene.Deces(10, 08, 1986);
            paul.Deces(1, 12, 1970);
            jean.ACommePere(marcel);
            jean.ACommeMere(marie);
            marie.ACommePere(paul);
            marie.ACommeMere(helene);


            Console.WriteLine("\tjean.Afficher()");
            Console.WriteLine();
            jean.Afficher();
            Console.WriteLine("----------------------");
            Console.WriteLine("\thelene.Afficher()");
            Console.WriteLine();
            helene.Afficher();
            Console.WriteLine("----------------------");
            Console.WriteLine("\tjean.AfficherGenealogie()");
            Console.WriteLine();
            jean.AfficherGenealogie();
        }
    }
}
