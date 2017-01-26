using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poprawa136039
{
    class Osobowy : Pojazd
    {
        private bool klimatyzacja;
        private bool kombi;

        public Osobowy(string marka, string model, double cenaZaDzien, bool klimatyzacja, bool kombi)
            :base(marka, model,cenaZaDzien)
        {
            this.klimatyzacja = klimatyzacja;
            this.kombi = kombi;
        }

        public override string ToString()
        {
            return "Osobowy, marka: " + marka + ", model: " + model + ", cena za dzien" + cenaZaDzien + ", klimatyzacja: " + klimatyzacja + ", kombi: " + kombi;
        }

        public override double ObliczKoszt(int cena)
        {
            if (!klimatyzacja && !kombi)
            {
                return ((136039 / 100) + cenaZaDzien);
            }
            else
            {
                if (kombi)
                    return cenaZaDzien * cena;
                else
                {
                    return 500;
                }
            }

        }

    }
}
