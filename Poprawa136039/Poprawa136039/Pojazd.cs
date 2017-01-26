using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poprawa136039
{
    abstract class Pojazd : IKoszt
    {
        protected string marka;
        protected string model;
        protected double cenaZaDzien;

        public Pojazd(string marka, string model, double cenaZaDzien)
        {
            this.marka = marka;
            this.model = model;
            this.cenaZaDzien = cenaZaDzien;
        }


        public abstract double ObliczKoszt(int cena);
    }
}
