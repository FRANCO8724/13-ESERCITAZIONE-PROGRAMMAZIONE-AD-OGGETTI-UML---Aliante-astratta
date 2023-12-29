using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{
    internal class Coda : Classe_astratta
    {
        public double Lunghezza { get; set; }

        public Coda(double _Lunghezza)
        {
            Lunghezza = _Lunghezza;
        }
        public override string Descrizione()
        {
            return "";
        }

        public override double Costo()
        {
            return Lunghezza;
        }

        public override void Add(Classe_astratta componente)
        {
            throw new InvalidOperationException("Impossibile aggiungere componenti a una Coda");
        }

        public override void Remove(Classe_astratta componente)
        {
            throw new InvalidOperationException("Impossibile rimuovere componenti da una Coda");
        }

        public override Classe_astratta GetChild(int index)
        {
            throw new InvalidOperationException("Una Coda non ha componenti figlio");
        }
    }
}
