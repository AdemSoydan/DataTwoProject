using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTwo
{
    class TeslimatSinifi
    {
        private string yemekAdi;
        private int adet;

        public TeslimatSinifi(string yemekAdi,int adet)
        {
            this.yemekAdi = yemekAdi;
            this.adet = adet;
        }
        
        public override string ToString()
        {
            return yemekAdi+ "  " + adet;
        }
    }
}
