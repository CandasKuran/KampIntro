using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();                 //burda asagida olusturudugumuz "Kurs" classina bir kurs ekliyoruz.
            kurs1.KursAdi = "C#";               //ve burda ise bu kursun icerisindeki ozellikleri bu sekilde tanimliyoruz
            kurs1.Egitmen = "Engin Demirog";    //
            kurs1.IzlenmeOrani = "68";

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.Egitmen = "Candas Kuran";
            kurs2.IzlenmeOrani = "75";

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Php";
            kurs3.Egitmen = "Ali Veli";
            kurs3.IzlenmeOrani = "45";

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Hasan Huseyin";
            kurs4.IzlenmeOrani = "100";

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen); // => comment line. yani yorum satiri

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };     //burda bir array olusturup kurslari icerisine atiyoruz.

                                                                //burda yapmamiz gereken tek sey yukarda Kurs classinda olusturdugumuz yeni kurs
                                                                //yani kurs4 u dizinimize ekliyoruz. geri kalani foreach dongumuz ile yerlesiyor.

            foreach (var kurs in kurslar)                           //burdaki vardan sonraki kurs tamamen takma ad. yani kurs gidecek ve tek tek kyukarda vermis oldughumuz kurslar dizininde tek tek donguye girecek
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }
                




            Console.WriteLine("Hello World!");
        }
    }

    // class demek icerisine birden fazla ozellik tanimlayabilmek demektir. class tanimlarken "prop" fonksiyounu ile aciyoruz.
    // prop ise "property" yani ozellik kelimesinden geliyor.
    class Kurs
    {
        public string KursAdi { get; set; }   //burda olusturdugumuz prop larin string veya int gibi ozelliklerini tanimlayip isim veriyoruz.
        public string Egitmen { get; set; }
        public string IzlenmeOrani { get; set; }
    }






}

// class ornegi
