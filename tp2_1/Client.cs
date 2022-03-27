using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tp2_1
{
   public class Client
    {
        private string _nom;
        private string _prenom;
        private int _age;

        public Client(string nom, string prenom, int age) {
            this._nom = nom;
            this._prenom = prenom;
            this._age = age;
        }

        public string nom {

            get { return _nom; }
            set {_nom = value;}
        }

        public string prenom { get { return _prenom; } set { _prenom = value; } }
        public int age { get { return _age; } set { _age = value; } }

        public string identifie() { return (nom + "   " + prenom + "   " + age.ToString()); }

    }
}
