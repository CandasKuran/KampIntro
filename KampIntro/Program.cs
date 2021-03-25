using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip guvenligi
            string kategoriEtiketi =  "Kategoriler";  //burda string ile bir degisken tanimliyoruz.python(def)
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;  //ondalikli sayailari "double" ile,python "float"
            bool sistemeGirisYapmisMi = true; //burda ise if blogunda giris yapip yapmadigini burdaki bool ile ogreniyoruz.
            
            double dolarDun = 7.35;
            double dolarBugun = 7.35;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Dolar deger kaybetti");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Dolar deger kazandi");
            }
            else
            {
                Console.WriteLine("Dolar sabit");
            }
          
            
            
            // if yaptiktan sonra iki defa tab a basinca otomatik olarak if blogunu olusturuyor.
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanici ayarlari butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);  //burda ise yukarida tanimladigimiz degiskeni Console.WriteLine ile ekrana yazdiriyoruz,python(print)




        }
    }
}

