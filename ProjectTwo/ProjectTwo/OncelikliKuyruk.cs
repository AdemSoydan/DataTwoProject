using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTwo
{
    class OncelikliKuyruk
    {
        List<MahalleSinifi> mahalleler;

        public void ekle(MahalleSinifi yeniMahalle)
        {
            mahalleler.Add(yeniMahalle);
        }
        public void sil()
        {
            MahalleSinifi enFazlaTeslimataSahipMahalle =  enFazlaTeslimatOlanMahalleyiBul();
            mahalleler.Remove(enFazlaTeslimataSahipMahalle);
        }
        private MahalleSinifi enFazlaTeslimatOlanMahalleyiBul()
        {
            MahalleSinifi enFazlaTeslimataSahipMahalle = new MahalleSinifi("");
            foreach (MahalleSinifi mahalle in mahalleler)
            {
                if (mahalle.TeslimatList.Capacity > enFazlaTeslimataSahipMahalle.TeslimatList.Capacity)
                {
                    enFazlaTeslimataSahipMahalle = mahalle;
                    return mahalle;
                }
                else if (mahalle.TeslimatList.Capacity == enFazlaTeslimataSahipMahalle.TeslimatList.Capacity)
                {
                    enFazlaTeslimataSahipMahalle = mahalle;
                    return mahalle;
                }
            }
            return enFazlaTeslimataSahipMahalle;
        }
    }
}
