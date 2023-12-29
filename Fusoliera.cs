using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{
    internal class Fusoliera : Classe_astratta
    {
        public string Materiale { get; set; }
        public double Lunghezza { get; set; }

        public Fusoliera( double _Lunghezza , string _Materiale)
        {
            Lunghezza = _Lunghezza;
            Materiale = _Materiale;
        }
        public override string Descrizione()
        {
            return "Materiale: " + Materiale;
        }

        public override double Costo()
        {
            return Lunghezza;
        }

        public override void Add(Classe_astratta componente)
        {
            throw new InvalidOperationException("Impossibile aggiungere componenti a una Fusoliera");
        }

        public override void Remove(Classe_astratta componente)
        {
            throw new InvalidOperationException("Impossibile rimuovere componenti da una Fusoliera");
        }

        public override Classe_astratta GetChild(int index)
        {
            throw new InvalidOperationException("Una Fusoliera non ha componenti figlio");
        }

    }
}