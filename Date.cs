using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbreGenealogique
{
    class Date
    {
        private int _jour;
        private int _mois;
        private int _annee;

        public int Jour { get => _jour; set => _jour = value; }
        public int Mois { get => _mois; set => _mois = value; }
        public int Annee { get => _annee; set => _annee = value; }

        public Date(int jour, int mois, int annee)
        {
            Jour = jour;
            Mois = mois;
            Annee = annee;
        }

        public string VersChaine()
        {
            return $"{Jour}/{Mois}/{Annee}";
        }
    }
}
