using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {

            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elmasi";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elmasi";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakir Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2};

            foreach (Urun urun in urunler)  // in urunler demek bir ust satirda olusturdugumuz urunler arryini tek tek gez demek. icin de donecegimiz arrayi belirtiyoruz.
                                            // ortadaki urun ise tamemen takma isimdir. x versek bile degisen birsey olmaz.
                                            // en bastaki Urun ise calistigimiz classi veriyoruz.
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------------");

            }

            Console.WriteLine("-----------Metotlar------------------");
            
            //instance => class ornegi olusturma
            //encapsulation => kapsulleme demek. ayri ayri yazacagimiza bir duzen icine sokuyoruz buna da kapsulleme denir.
            SepetManager sepetManager = new SepetManager();  //SepetManager.cs de olusturdugumuz metdou burda cagirmak icin kullaniyoruz.
            sepetManager.Ekle(urun1); //bu sekilde metodu cagiriyoruz.
            sepetManager.Ekle(urun2);

       
        }
    }
}



