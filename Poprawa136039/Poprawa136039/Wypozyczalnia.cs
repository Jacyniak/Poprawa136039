using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poprawa136039
{
    class Wypozyczalnia : IKoszt
    {
        private int ileWolnych;
        private int ileAut;

        public Wypozyczalnia(int ileWolnych, int ileAut)
        {
            this.ileAut = ileAut;
            this.ileWolnych = ileWolnych;
        }

        public double ObliczKoszt(int cena)
        {
            if (ileWolnych <= (ileAut / 2))
            {
                return cena * 34;
            }
            else
            {
                return 734;
            }
        }
    }
}
