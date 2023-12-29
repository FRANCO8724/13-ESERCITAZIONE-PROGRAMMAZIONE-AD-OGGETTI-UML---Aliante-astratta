using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{
    internal class Ala : Classe_astratta
    {
        public double Lunghezza { get; set; }
        public double Apertura { get; set; }


        public Ala(double _Lunghezza, double _Apertura)
        {
            Lunghezza = _Lunghezza;
            Apertura = _Apertura;
        }

        public override string Descrizione()
        {
            return "";
        }

        public override double Costo()
        {
            return Lunghezza * Apertura;
        }

        public override void Add(Classe_astratta componente)
        {
            throw new InvalidOperationException("Impossibile aggiungere componenti a una Ala");
        }

        public override void Remove(Classe_astratta componente)
        {
            throw new InvalidOperationException("Impossibile rimuovere componenti da una Ala");
        }

        public override Classe_astratta GetChild(int index)
        {
            throw new InvalidOperationException("Una Ala non ha componenti figlio");
        }
    }
}

