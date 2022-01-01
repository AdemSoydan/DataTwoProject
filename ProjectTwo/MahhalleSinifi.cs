using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTwo
{
    class MahalleSinifi
    {
        private string mahalleAdi;
        private List<TeslimatSinifi> teslimatList;

        public MahalleSinifi(string mahalleAdi)
        {
            this.mahalleAdi = mahalleAdi;
            teslimatList = new List<TeslimatSinifi>();
        }
        public void YeniTeslimatEkle(TeslimatSinifi yeniTeslimat)
        {
            teslimatList.Add(yeniTeslimat);
        }
        public int MahalledekiTeslimatSayisi()
        {
            return teslimatList.Count;
        }

        public string MahalleAdi { get { return mahalleAdi; } set { } }
        public List<TeslimatSinifi> TeslimatList { get { return teslimatList; } set { } }

    }
}
