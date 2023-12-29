using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{

    internal class Ruota : Classe_astratta
    {

        public double Pollici { get; set; }
        public double Altezza { get; set; }
        public double Larghezza { get; set; }
        public double Raggio { get; set; }

        public Ruota(double _Pollici, double _Altezza, double _Larghezza, double _Raggio)
        {
            Pollici = _Pollici;
            Altezza = _Altezza;
            Larghezza = _Larghezza;
            Raggio = _Raggio;
        }

        public override string Descrizione()
        {
            return "";
        }

        public override double Costo()
        {
            return Pollici * Altezza * Larghezza * Raggio;
        }

        public override void Add(Classe_astratta componente)
        {
            throw new InvalidOperationException("Impossibile aggiungere componenti a una Ruota");
        }

        public override void Remove(Classe_astratta componente)
        {
            throw new InvalidOperationException("Impossibile rimuovere componenti da una Ruota");
        }

        public override Classe_astratta GetChild(int index)
        {
            throw new InvalidOperationException("Una Ruota non ha componenti figlio");
        }

    }
}
