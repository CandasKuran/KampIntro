using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //bu sekilde tek tek string acip eklemek yarine bir array olusturup sadece onun icerisine ekleme yapiyoruz
            string kurs1 = "Yazilim gelistirici yetistirme kampi";
            string kurs2 = "Programlamaya baslangic icin temel kurs";
            string kurs3 = "Java";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            
            
            //array - dizi  string[] kurslar = new string[] seklinde yeni bir array yani dizi olusturuyoruz. boylelikle birden fazla 
            // urunu  bir satir kod ile yapabiliyoruz. 

            string[] kurslar = new string[] { "Yazilim gelistirici yetistirme kampi", "Programlamaya baslangic icin temel kurs", "java",
                "python","php"};

            for (int i = 0; i < kurslar.Length; i++)     //i++ => i yi 1 1 arttir demek. 1 den basla i<10 sarti tamamlana kadar donguyu devam ettir,.
            {                                  //i=i+2 => i yi 2 2 arttir demek, kurslar.Lenght ile dinamik hale getiriyoruz. boylece kurslar arrayimizin icine ekledigimiz surece  dongumuze dahil olacak

                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti");


            foreach (string kurs in kurslar)    //dizi temelli yapilari tek tek donmek icin foreach dongusu kullanilir. yukardaki for dongusu yerine bunu kullanmak hem daha kolay hem daha ksia
            {
                Console.WriteLine(kurs);
            }
            
            
            Console.WriteLine("Sayfa sonu - footer ");
        }
    }
}

            
