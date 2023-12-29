using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{
    internal abstract class Classe_astratta
    {

        public abstract double Costo();
        public abstract string Descrizione();

        double CostoTotale = 0;

        public virtual void Add(Classe_astratta componente)
        {
            throw new InvalidOperationException("Impossibile aggiungere componenti");
        }

        public virtual void Remove(Classe_astratta componente)
        {
            throw new InvalidOperationException("Impossibile rimuovere componenti");
        }

        public virtual Classe_astratta GetChild(int index)
        {
            throw new InvalidOperationException("Impossibile ottenere componenti");
        }

        public double SommaCosti()
        {
            CostoTotale = CostoTotale + Costo();

            return CostoTotale;
        }

        public string Specifiche()
        {
            return Descrizione();
        }
    }
}
