using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Ali", "Veli", "Hasan", "Huseyin" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];   //burda arrayimiza yeni bir obje ekliyoruz ve yazdirinca hata almayacaz ve eklenmis olacak.
            //                           // ama tekrar [0]. veya [1]. indexteki elemani yazdirmak istersek bos gelecek.
            //                           //cunku biz new diyerek referans adresini degistirerek 5 elemanli bir yeni dizi olusuyor ve
            //                           //diger elemanlari bosluk olarak kaliyor.
            //isimler[4] = "Ilker";               //bu yuzden C# veya Java gibi dillerde genelde array ler cok sik kullanilmaz. bunun yerine
            //                                    //KOLEKSIYONLAR kullanilir.
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string> { "Ali", "Veli", "Hasan", "Huseyin" }; //listeler ise boyle olusturulur.
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);  
            isimler2.Add("ilker");              //burda ise arraylarin disinda ekleyip yazdiriyoruz. ve listemiz bozulmuyor.
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            

        }
    }
}
