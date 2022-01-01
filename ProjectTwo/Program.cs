using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] MahalleAdı = { "Özkanlar", "Evka 3", "Atatürk", "Erzene", "Kazımdirik", "Mevlana", "Doğanlar", "Ergene","Kavacık" };
            string[] yemekler = { "pilav", "suşi", "tavuk", "döner", "iskender", "mantı", "pizza" };
            
            
            int[] TeslimatSayısı = { 5, 2, 7, 2, 7, 3, 0, 1,10 };
            Random random = new Random();

            ArrayList motoKuryeArray = new ArrayList();
            
            for (int i = 0; i < MahalleAdı.Length; i++)
            {
                int teslimatSayisi = TeslimatSayısı[i];
                MahalleSinifi yeniMahalle = new MahalleSinifi(MahalleAdı[i]);
                for (int j = 0; j < teslimatSayisi; j++)
                {
                    yeniMahalle.YeniTeslimatEkle(new TeslimatSinifi(yemekler[2], random.Next(1, 3)));
                }

                motoKuryeArray.Add(yeniMahalle);
            }
            foreach (MahalleSinifi mahalle in motoKuryeArray)
            {
                Console.WriteLine(mahalle.MahalleAdi);
                foreach (TeslimatSinifi item in mahalle.TeslimatList)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            int listeSayisi = 0;
            int toplamteslimatSayisi = 0;
            for (int i = 0; i < motoKuryeArray.Count; i++)
            {
                listeSayisi++;
                MahalleSinifi mahalleler = (MahalleSinifi)motoKuryeArray[i];
                toplamteslimatSayisi += mahalleler.MahalledekiTeslimatSayisi();
            }
            Console.WriteLine("Arraylistteki liste sayisi :" + listeSayisi);
            Console.WriteLine("Toplam teslimat sayisi :" + toplamteslimatSayisi);
           

            // mahalleleri yıgıta ekle
            StackX mahalleStack = new StackX(100);
            foreach (MahalleSinifi item in motoKuryeArray)
            {
                mahalleStack.push(item);
            }
            // stackden cikarip bilgileri yazdir
            Console.WriteLine("mahalle sayisi" + mahalleStack.Count());
            int mahalleSayisi = mahalleStack.Count();
            for (int i = 0; i < mahalleSayisi; i++)
            {
                MahalleSinifi currentMahalle = mahalleStack.pop();
                Console.WriteLine(currentMahalle.MahalleAdi);
                foreach (TeslimatSinifi teslimat in currentMahalle.TeslimatList)
                {
                    Console.WriteLine(teslimat);
                }
            }
            // queue icin islemler
            Console.WriteLine("---------------------------");
            Console.WriteLine("QUEUE TIMEEEE");
            Console.WriteLine("---------------------------");
            MyQueue mahalleQueue = new MyQueue(100);
            foreach (MahalleSinifi item in motoKuryeArray)
            {
                mahalleQueue.insert(item);
            }
            for (int i = 0; i < mahalleSayisi; i++)
            {
                MahalleSinifi currentMahalle = mahalleQueue.remove();
                Console.WriteLine(currentMahalle.MahalleAdi);
                foreach (TeslimatSinifi teslimat in currentMahalle.TeslimatList)
                {
                    Console.WriteLine(teslimat);
                }
            }
            Console.Read();
        }
    }
}
