using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar
{
    class SepetManager
    {
        //syntax => yazim sekli
        //naming convention => yazim kurallari demek. C# da bir yazim kurali olarak verdigimiz isimlerin bas harfleri buyuk yazilir.
        public void Ekle(Urun urun)   //bir method olusturup adini Ekle yaptik. 
                                      //Urun metodun tipi, diger urun ise bu metodun isi. bu metodu kullanirken bunu kullanabiliriz.
        {
            Console.WriteLine("Sepete Eklendi : " + urun.Adi);
         
        }
        // bir class icerisinde iki farkli metod olusturabiliyoruz. burda ise yukardaki gibi bir fonksiyon yapiyoruz.,
        //public void Ekle2(string urunAdi, string aciklama, double fiyat, )
        //{
        //    Console.WriteLine("Sepete Eklendi : " + urunAdi);
        //} 
    }

}
