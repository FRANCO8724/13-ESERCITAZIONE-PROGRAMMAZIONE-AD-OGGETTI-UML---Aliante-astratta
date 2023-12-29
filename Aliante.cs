using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{
    internal class Aliante : Classe_astratta
    {
        public string deala { get; set; }
        public string deFusoliera { get; set; }
        public string deCoda { get; set; }

        public Aliante(string _deala, string _deFusoliera, string _deCoda)
        {
            deala = _deala;
            deFusoliera = _deFusoliera;
            deCoda = _deCoda;
        }

        public override string Descrizione()
        {
            return "Ala: " + deala + ", Fusoliera : " + deFusoliera + ", Coda : " + deCoda;
        }

        public override double Costo()
        {
            return 0;
        }

        public override void Add(Classe_astratta componente)
        {
            throw new InvalidOperationException("Impossibile aggiungere componenti a una Aliante");
        }

        public override void Remove(Classe_astratta componente)
        {
            throw new InvalidOperationException("Impossibile rimuovere componenti da una Aliante");
        }

        public override Classe_astratta GetChild(int index)
        {
            throw new InvalidOperationException("Una Fusoliera non ha componenti Aliante");
        }
    }
}

