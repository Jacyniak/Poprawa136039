using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poprawa136039
{
    class Autobus : Pojazd
    {
        private int liczbaMiejsc;

        public Autobus(string marka, string model, double cenaZaDzien, int liczbaMiejsc)
            :base(marka, model, cenaZaDzien)
        {
            this.liczbaMiejsc = liczbaMiejsc;
        }

        public override string ToString()
        {
            return "Autobus, marka: " + marka + ", model: " + model + ", cena za dzien" + cenaZaDzien + ", ilosc miejsc:  " + liczbaMiejsc;
        }

        public override double ObliczKoszt(int cena)
        {
            if (liczbaMiejsc > 50)
            {
                return cena * 100;
            }
            else
            {
                return cenaZaDzien * cena;
            }
        }
    }
}
