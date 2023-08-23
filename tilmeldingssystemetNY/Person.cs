using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tilmeldingssystemetNY
{
    internal class Person
    {

        // instansfelter
        private int _id;
        private string _navn;
        private string _adresse;
        private string _patrulje;
        private DateTime _fødselsdato;
        private bool _enUge;

        // properties

        public int ID { get; }
        public string Navn { get; }

        public string Adresse { get; }

        public string Patrulje { get; }

        public DateTime FødselsDato { get; }

        public bool EnUge { get; }



        // konstruktør

        public Person(int id, string navn, string adresse, string patrulje, DateTime fødselsDato, bool enUge)
        {
            ID = id;
            Navn = navn;
            Adresse = adresse;
            Patrulje = patrulje;
            FødselsDato = fødselsDato;
            enUge = EnUge;

        }

        // ToString() metode

        public override string ToString()
        {
            return $" ID: {ID}, Navn: {Navn}, Adresse: {Adresse}, Patrulje: {Patrulje}, Fødselsdato: {FødselsDato}, Tilmeldt en uge: {EnUge}";
        }

    }
}
